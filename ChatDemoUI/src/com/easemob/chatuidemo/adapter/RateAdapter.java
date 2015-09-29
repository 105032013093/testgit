package com.easemob.chatuidemo.adapter;

import com.easemob.applib.model.RateModel;
import com.easemob.applib.model.RateModel;
import com.easemob.chatuidemo.R;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class RateAdapter extends BaseAdapter {
	private Context context;
	
	public RateAdapter(Context context){
		this.context=context;
	}
	public Context getContext(){
		return context;
	}
	
	
	//数据
		private RateModel[] data=new RateModel[]{
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
				new RateModel("西安马拉松", R.drawable.default_pic_4),
		};

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return data.length;
	}

	@Override
	public RateModel getItem(int arg0) {
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
		LinearLayout mLlRateItem=null;
		if(arg1!=null){
			mLlRateItem=(LinearLayout) arg1;
		}else{
			mLlRateItem=(LinearLayout) LayoutInflater.from(getContext()).inflate(R.layout.activity_rate_item, null);
		}
		ImageView mIvRate=(ImageView) mLlRateItem.findViewById(R.id.iv_rate);
		TextView mTvRateName=(TextView) mLlRateItem.findViewById(R.id.tv_rate_name);
	//	TextView mTvRateType=(TextView) mLlRateItem.findViewById(R.id.tv_sport_site_type);
		
		
		RateModel model=getItem(arg0);
		mIvRate.setImageResource(model.getIconId());
		mTvRateName.setText(model.getrate_name());
	//	mTvRateType.setText(model.getSport_site_describtion());
		
		return mLlRateItem;
	}

}
