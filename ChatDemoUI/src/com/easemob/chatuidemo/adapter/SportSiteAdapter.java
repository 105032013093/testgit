package com.easemob.chatuidemo.adapter;

import com.easemob.applib.model.SportSiteModel;


import com.easemob.chatuidemo.R;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class SportSiteAdapter extends BaseAdapter {
	
	private Context context;
	
	public SportSiteAdapter(Context context){
		this.context=context;
	}
	public Context getContext(){
		return context;
	}
	
	//数据
	private SportSiteModel[] data=new SportSiteModel[]{
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
			new SportSiteModel("奥力健身馆","健身",R.drawable.groups_icon),
	};
	

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return data.length;
	}

	@Override
	public SportSiteModel getItem(int arg0) {
		// TODO Auto-generated method stub
		return data[arg0];
	}

	@Override
	public long getItemId(int arg0) {
		// TODO Auto-generated method stub
		return arg0;
	}

	@Override
	public View getView(int arg0, View arg1, ViewGroup arg2) {
		LinearLayout mLlSportSiteItem=null;
		if(arg1!=null){
			mLlSportSiteItem=(LinearLayout) arg1;
		}else{
			mLlSportSiteItem=(LinearLayout) LayoutInflater.from(getContext()).inflate(R.layout.activity_sport_site_item, null);
		}
		ImageView mIvSportSite=(ImageView) mLlSportSiteItem.findViewById(R.id.iv_sport_site);
		TextView mTvSportSiteName=(TextView) mLlSportSiteItem.findViewById(R.id.tv_sport_site_name);
		TextView mTvSportSiteType=(TextView) mLlSportSiteItem.findViewById(R.id.tv_sport_site_type);
		
		
		SportSiteModel model=getItem(arg0);
		mIvSportSite.setImageResource(model.getIconId());
		mTvSportSiteName.setText(model.getSport_site_name());
		mTvSportSiteType.setText(model.getSport_site_describtion());
		
		return mLlSportSiteItem;
	}

}
