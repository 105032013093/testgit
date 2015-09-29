package com.easemob.chatuidemo.activity;

import com.easemob.chatuidemo.Constant;
import com.easemob.chatuidemo.R;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.LinearLayout;

public class FindFragment extends Fragment{
	private LinearLayout mLlRate;
	private LinearLayout mLlOrderSite;
     @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
    		Bundle savedInstanceState) {
    	// TODO Auto-generated method stub
    	return inflater.inflate(R.layout.fragment_find,container,false);
    }
     
     @Override
     public void onActivityCreated(Bundle savedInstanceState) {
     	super.onActivityCreated(savedInstanceState);
     	//
     	if(savedInstanceState != null && savedInstanceState.getBoolean("isConflict", false))
 		    return;
     	mLlRate=(LinearLayout)getView(). findViewById(R.id.ll_rate);
     	mLlOrderSite=(LinearLayout) getView().findViewById(R.id.ll_order_site);
     	
        mLlRate.setOnClickListener(new OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
//				Intent intent=new Intent(getActivity(),BigGroupActivity.class);
					Intent intent=new Intent(getActivity(),RateActivity.class);
					startActivity(intent);
				}
			});
     	
     	mLlOrderSite.setOnClickListener(new OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
					Intent intent=new Intent(getActivity(),SportSiteActivity.class);
					startActivity(intent);
				}
			});
     }
     
     public void onSaveInstanceState(Bundle outState) {
 		super.onSaveInstanceState(outState);
 	    if(((MainActivity)getActivity()).isConflict){
 	    	outState.putBoolean("isConflict", true);
 	    }else if(((MainActivity)getActivity()).getCurrentAccountRemoved()){
 	    	outState.putBoolean(Constant.ACCOUNT_REMOVED, true);
 	    }
 	    
 	}
}
