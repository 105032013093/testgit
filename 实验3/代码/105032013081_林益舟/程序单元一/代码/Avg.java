package ƽ���ɼ�;

public class Avg {
     private double yuwen;
     private double math;
     private double yingyu;
     private double average;
     
	public double getYuwen() {
		return yuwen;
	}
	public void setYuwen(double yuwen) {
		if(yuwen>100){
			System.out.println("�ɼ�������Χ");
		}
		this.yuwen = yuwen;
	}
	public double getMath() {
		return math;
	}
	public void setMath(double math) {
		if(yuwen>100){
			System.out.println("�ɼ�������Χ");
		}
		this.math = math;
	}
	public double getYingyu() {
		return yingyu;
	}
	public void setYingyu(double yingyu) {
		if(yuwen>100){
			
		}
		this.yingyu = yingyu;
	}
     
     public double  avg(double yuwen,double yingyu,double math){
    	 if(yingyu<0||yuwen<0||math<0){
    		 System.out.println("�ɼ�����С��0");
    		 return -1;
    	 }else if(yingyu>100||yuwen>100||math>100){
    		 System.out.println("�ɼ�������Χ");
    		 return -1;
    	 }else{
    	 average=(yuwen+yingyu+math)/3;
    	 System.out.println("ƽ���ɼ�Ϊ��"+average);
    	 return average;
    	 }
     }
}
