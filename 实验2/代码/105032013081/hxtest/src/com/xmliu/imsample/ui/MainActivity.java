package com.xmliu.imsample.ui;

import java.util.ArrayList;
import java.util.List;

import com.easemob.EMCallBack;
import com.easemob.chat.EMChat;
import com.easemob.chat.EMChatManager;
import com.easemob.chat.EMContactListener;
import com.easemob.chat.EMContactManager;
import com.easemob.chat.EMNotifier;
import com.easemob.exceptions.EaseMobException;
import com.xmliu.imsample.AppManager;
import com.xmliu.imsample.BaseActivity;
import com.xmliu.imsample.R;
import com.xmliu.imsample.adapter.FriendListAdapter;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.util.Log;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemLongClickListener;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends BaseActivity {

	private ListView mListView;
	private Button mAddBtn;
	private Button logoutBtn;
	private View addView;
	private EditText mIdET;
	private EditText mReasonET;
	private TextView mUserTV;
	private TextView mGoTV;
	private FriendListAdapter mAdapter;
	private List<String> userList = new ArrayList<String>();

	/* 常量 */
	private final int CODE_ADD_FRIEND = 0x00001;

	@Override
	protected void onDestroy() {
		// TODO Auto-generated method stub
		super.onDestroy();
	}

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_chat_friends);

		mHandler = new Handler() {
			@Override
			public void handleMessage(Message msg) {
				// TODO Auto-generated method stub
				super.handleMessage(msg);
				switch (msg.what) {
				case CODE_ADD_FRIEND:
					Toast.makeText(getApplicationContext(), "请求发送成功，等待对方验证",
							Toast.LENGTH_SHORT).show();
					break;

				default:
					break;
				}
			}

		};

		EMContactManager.getInstance().setContactListener(
				new MyContactListener());
		EMChat.getInstance().setAppInited();

		mListView = (ListView) findViewById(R.id.chat_listview);
		mAddBtn = (Button) findViewById(R.id.chat_add_btn);
		mUserTV = (TextView) findViewById(R.id.current_user);
		mGoTV = (TextView) findViewById(R.id.friend_list_go);
		logoutBtn = (Button) findViewById(R.id.chat_logout_btn);

		mUserTV.setText(EMChatManager.getInstance().getCurrentUser());

		initList();

		mAddBtn.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				addView = LayoutInflater.from(MainActivity.this).inflate(
						R.layout.chat_add_friends, null);
				mIdET = (EditText) addView
						.findViewById(R.id.chat_add_friend_id);
				mReasonET = (EditText) addView
						.findViewById(R.id.chat_add_friend_reason);
				new AlertDialog.Builder(MainActivity.this)
						.setTitle("添加好友")
						.setView(addView)
						.setPositiveButton("确定",
								new DialogInterface.OnClickListener() {
									@Override
									public void onClick(DialogInterface dialog,
											int which) {
										dialog.dismiss();
										String idStr = mIdET.getText()
												.toString().trim();
										String reasonStr = mReasonET.getText()
												.toString().trim();
										try {
											EMContactManager.getInstance()
													.addContact(idStr,
															reasonStr);
											mHandler.sendEmptyMessage(CODE_ADD_FRIEND);
										} catch (EaseMobException e) {
											// TODO Auto-generated catch block
											e.printStackTrace();
											Log.i("TAG", "addContacterrcode==>"
													+ e.getErrorCode());
										}// 需异步处理
									}
								})
						.setNegativeButton("取消",
								new DialogInterface.OnClickListener() {
									public void onClick(DialogInterface dialog,
											int whichButton) {
										dialog.dismiss();
									}
								}).create().show();

			}
		});
		
		//退出
		logoutBtn.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub

				showLogoutDialog();

			}
		});

		mListView.setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				// TODO Auto-generated method stub
				startActivity(new Intent(MainActivity.this,
						ChatListActivity.class).putExtra("userid",
						userList.get(arg2)));
			}
		});

		mListView.setOnItemLongClickListener(new OnItemLongClickListener() {

			@Override
			public boolean onItemLongClick(AdapterView<?> arg0, View arg1,
					int arg2, long arg3) {
				// TODO Auto-generated method stub
				showDeleteDialog(userList.get(arg2));
				return true;
			}
		});
	}

	private void initList() {
		try {
			userList.clear();
			userList = EMContactManager.getInstance().getContactUserNames();
			mAdapter = new FriendListAdapter(MainActivity.this, userList);
			mListView.setAdapter(mAdapter);
		} catch (EaseMobException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
			Log.i("TAG", "usernames errcode==>" + e1.getErrorCode());
			Log.i("TAG", "usernames errcode==>" + e1.getMessage());
		}// 需异步执行
	}

	private class MyContactListener implements EMContactListener {

		@Override
		public void onContactAgreed(String username) {
			// 好友请求被同意
			Log.i("TAG", "onContactAgreed==>" + username);
			// 提示有新消息
			EMNotifier.getInstance(getApplicationContext()).notifyOnNewMsg();
			Toast.makeText(getApplicationContext(), username + "同意了你的好友请求",
					Toast.LENGTH_SHORT).show();
		}

		@Override
		public void onContactRefused(String username) {
			// 好友请求被拒绝
			Log.i("TAG", "onContactRefused==>" + username);
		}

		@Override
		public void onContactInvited(String username, String reason) {
			// 收到好友添加请求
			Log.i("TAG", username + "onContactInvited==>" + reason);
			showAgreedDialog(username, reason);
			EMNotifier.getInstance(getApplicationContext()).notifyOnNewMsg();
		}

		@Override
		public void onContactDeleted(List<String> usernameList) {
			// 好友被删除时回调此方法
			Log.i("TAG", "usernameListDeleted==>" + usernameList.size());
		}

		@Override
		public void onContactAdded(List<String> usernameList) {
			// 添加了新的好友时回调此方法
			for (String str : usernameList) {
				Log.i("TAG", "usernameListAdded==>" + str);
			}
		}
	}

	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		if (keyCode == KeyEvent.KEYCODE_BACK) {

			showExitDialog();
		}

		return super.onKeyDown(keyCode, event);
	}

	private void showLogoutDialog() {
		new AlertDialog.Builder(MainActivity.this)
				.setTitle("应用提示")
				.setMessage(
						"确定要注销" + EMChatManager.getInstance().getCurrentUser()
								+ "用户吗？")
				.setPositiveButton("确定", new DialogInterface.OnClickListener() {
					@Override
					public void onClick(DialogInterface dialog, int which) {
						// EMChatManager.getInstance().logout();
						logout(new EMCallBack() {

							@Override
							public void onSuccess() {
								// TODO Auto-generated method stub
								startActivity(new Intent(MainActivity.this,
										ChatLoginActivity.class));
							}

							@Override
							public void onProgress(int arg0, String arg1) {
								// TODO Auto-generated method stub

							}

							@Override
							public void onError(int arg0, String arg1) {
								// TODO Auto-generated method stub

							}
						});

					}
				})
				.setNegativeButton("取消", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
					}
				}).show();
	}

	public void logout(final EMCallBack callback) {
		// setPassword(null);
		EMChatManager.getInstance().logout(new EMCallBack() {

			@Override
			public void onSuccess() {
				// TODO Auto-generated method stub
				if (callback != null) {
					callback.onSuccess();
				}
			}

			@Override
			public void onError(int code, String message) {
				// TODO Auto-generated method stub

			}

			@Override
			public void onProgress(int progress, String status) {
				// TODO Auto-generated method stub
				if (callback != null) {
					callback.onProgress(progress, status);
				}
			}

		});
	}

	private void showAgreedDialog(final String user, String reason) {
		new AlertDialog.Builder(MainActivity.this)
				.setTitle("应用提示")
				.setMessage(
						"用户 " + user + " 想要添加您为好友，是否同意？\n" + "验证信息：" + reason)
				.setPositiveButton("同意", new DialogInterface.OnClickListener() {
					@Override
					public void onClick(DialogInterface dialog, int which) {
						try {
							EMChatManager.getInstance().acceptInvitation(user);
							initList();
						} catch (EaseMobException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
							Log.i("TAG",
									"showAgreedDialog1==>" + e.getErrorCode());
						}
					}
				})
				.setNegativeButton("拒绝", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
						try {
							EMChatManager.getInstance().refuseInvitation(user);
						} catch (EaseMobException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
							Log.i("TAG",
									"showAgreedDialog2==>" + e.getErrorCode());
						}
					}
				})
				.setNeutralButton("忽略", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
						dialog.dismiss();
					}
				}).show();
	}

	private void showDeleteDialog(final String user) {
		new AlertDialog.Builder(MainActivity.this)
				.setTitle("应用提示")
				.setMessage("确定删除好友  " + user + " 吗？\n")
				.setPositiveButton("确定", new DialogInterface.OnClickListener() {
					@Override
					public void onClick(DialogInterface dialog, int which) {
						try {
							EMContactManager.getInstance().deleteContact(user);
							initList();
						} catch (EaseMobException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
							Log.i("TAG",
									"showAgreedDialog1==>" + e.getErrorCode());
						}
					}
				})
				.setNegativeButton("取消", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
						dialog.dismiss();
					}
				}).show();
	}

	private void showExitDialog() {
		new AlertDialog.Builder(MainActivity.this)
				.setTitle("应用提示")
				.setMessage(
						"确定要退出" + getResources().getString(R.string.app_name)
								+ "客户端吗？")
				.setPositiveButton("确定", new DialogInterface.OnClickListener() {
					@Override
					public void onClick(DialogInterface dialog, int which) {
						AppManager.getInstance().AppExit(MainActivity.this);
						MainActivity.this.finish();
					}
				})
				.setNegativeButton("取消", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
					}
				}).show();
	}

}
