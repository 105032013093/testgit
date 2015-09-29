package com.easemob.applib.model;

public class SportSiteModel {
     private String sport_site_name;
     private String sport_site_describtion;
     private int iconId;
     
     public SportSiteModel(String sport_site_name,String sport_site_describtion,int iconId){
    	setSport_site_name(sport_site_name);
    	setSport_site_describtion(sport_site_describtion);
    	setIconId(iconId);
     }

	public String getSport_site_name() {
		return sport_site_name;
	}

	public void setSport_site_name(String sport_site_name) {
		this.sport_site_name = sport_site_name;
	}

	public String getSport_site_describtion() {
		return sport_site_describtion;
	}

	public void setSport_site_describtion(String sport_site_describtion) {
		this.sport_site_describtion = sport_site_describtion;
	}

	public int getIconId() {
		return iconId;
	}

	public void setIconId(int iconId) {
		this.iconId = iconId;
	}
     
     
}
