package com.easemob.applib.model;

public class RateModel {
     private String rate_name;
//     private String sport_site_describtion;
     private int iconId;
     
     public RateModel(String rate_name,int iconId){
    	setrate_name(rate_name);
 //   	setSport_site_describtion(sport_site_describtion);
    	setIconId(iconId);
     }

	public String getrate_name() {
		return rate_name;
	}

	public void setrate_name(String rate_name) {
		this.rate_name = rate_name;
	}

//	public String getSport_site_describtion() {
//		return sport_site_describtion;
//	}

//	public void setSport_site_describtion(String sport_site_describtion) {
//		this.sport_site_describtion = sport_site_describtion;
//	}

	public int getIconId() {
		return iconId;
	}

	public void setIconId(int iconId) {
		this.iconId = iconId;
	}
     
     
}
