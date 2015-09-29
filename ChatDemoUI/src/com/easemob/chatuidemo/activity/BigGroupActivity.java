package com.easemob.chatuidemo.activity;

import com.easemob.chatuidemo.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.LinearLayout;

public class BigGroupActivity extends Activity implements OnClickListener{
	private LinearLayout mLlRateGroup;
	private LinearLayout mLlRefereeGroup;
	private LinearLayout mLlVolunteersGroup;
	private LinearLayout mLlAthletesGroup;
        @Override
        protected void onCreate(Bundle savedInstanceState) {
        	// TODO Auto-generated method stub
        	super.onCreate(savedInstanceState);
        	setContentView(R.layout.activity_big_group);
        	mLlRateGroup=(LinearLayout) findViewById(R.id.ll_rate_group);
        	mLlRefereeGroup=(LinearLayout) findViewById(R.id.ll_referee_group);
        	mLlVolunteersGroup=(LinearLayout) findViewById(R.id.ll_volunteers_group);
        	mLlAthletesGroup=(LinearLayout) findViewById(R.id.ll_athletes_group);
        	mLlRateGroup.setOnClickListener(this);
        	mLlRefereeGroup.setOnClickListener(this);
        	mLlVolunteersGroup.setOnClickListener(this);
        	mLlAthletesGroup.setOnClickListener(this);
        }
		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
			Intent intent=new Intent(BigGroupActivity.this,GroupsActivity.class);
			switch (v.getId()) {
			case R.id.ll_rate_group:
				startActivity(intent);
				break;
            case R.id.ll_referee_group:
            	startActivity(intent);
				break;
            case R.id.ll_volunteers_group:
            	startActivity(intent);
	            break;
            case R.id.ll_athletes_group:
            	startActivity(intent);
	            break;
			}
		}
}
