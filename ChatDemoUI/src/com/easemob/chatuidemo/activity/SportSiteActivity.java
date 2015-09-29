package com.easemob.chatuidemo.activity;

import com.easemob.chatuidemo.R;
import com.easemob.chatuidemo.adapter.SportSiteAdapter;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ListView;

public class SportSiteActivity extends Activity {
	private ListView mLvSportSite;
	private SportSiteAdapter sportSiteAdapter;
       @Override
    protected void onCreate(Bundle savedInstanceState) {
    	// TODO Auto-generated method stub
    	super.onCreate(savedInstanceState);
    	setContentView(R.layout.activity_sport_site);
    	mLvSportSite=(ListView) findViewById(R.id.lv_order_site);
    	sportSiteAdapter=new SportSiteAdapter(this);
        mLvSportSite.setAdapter(sportSiteAdapter);
    }
}
