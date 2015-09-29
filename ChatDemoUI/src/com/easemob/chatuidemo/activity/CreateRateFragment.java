package com.easemob.chatuidemo.activity;

import com.easemob.chatuidemo.Constant;
import com.easemob.chatuidemo.R;

import android.support.v4.app.Fragment;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.LinearLayout;

public class CreateRateFragment extends Fragment {
	 private LinearLayout mLlBigRate;
	 private LinearLayout mLlSmallRate;
            @Override
            public View onCreateView(LayoutInflater inflater, ViewGroup container,
            		Bundle savedInstanceState) {
            	// TODO Auto-generated method stub
            	return inflater.inflate(R.layout.fragment_create_rate,container,false);
            }
            @Override
            public void onActivityCreated(Bundle savedInstanceState) {
            	super.onActivityCreated(savedInstanceState);
            	//
            	if(savedInstanceState != null && savedInstanceState.getBoolean("isConflict", false))
        		    return;
            	mLlBigRate=(LinearLayout)getView(). findViewById(R.id.ll_big_rate);
            	mLlSmallRate=(LinearLayout) getView().findViewById(R.id.ll_small_rate);
               mLlBigRate.setOnClickListener(new OnClickListener() {
					
					@Override
					public void onClick(View arg0) {
						// TODO Auto-generated method stub
//					Intent intent=new Intent(getActivity(),BigGroupActivity.class);
						Intent intent=new Intent(getActivity(),GroupsActivity.class);
						startActivity(intent);
					}
				});
            	
            	mLlSmallRate.setOnClickListener(new OnClickListener() {
					
					@Override
					public void onClick(View arg0) {
						// TODO Auto-generated method stub
						Intent intent=new Intent(getActivity(),GroupsActivity.class);
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
