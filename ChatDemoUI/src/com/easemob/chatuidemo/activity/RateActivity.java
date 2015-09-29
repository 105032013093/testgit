package com.easemob.chatuidemo.activity;

import com.easemob.chatuidemo.R;
import com.easemob.chatuidemo.adapter.RateAdapter;
import com.easemob.chatuidemo.adapter.SportSiteAdapter;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ListView;

public class RateActivity extends Activity {
	private ListView mLvRate;
	private RateAdapter rateAdapter;
        @Override
        protected void onCreate(Bundle savedInstanceState) {
        	
        	// TODO Auto-generated method stub
        	super.onCreate(savedInstanceState);
        	setContentView(R.layout.activity_rate);
        	mLvRate=(ListView) findViewById(R.id.lv_rate);
        	rateAdapter=new RateAdapter(this);
            mLvRate.setAdapter(rateAdapter);
        }
}
