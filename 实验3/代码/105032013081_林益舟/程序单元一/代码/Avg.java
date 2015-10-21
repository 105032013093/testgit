package 平均成绩;

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
			System.out.println("成绩超出范围");
		}
		this.yuwen = yuwen;
	}
	public double getMath() {
		return math;
	}
	public void setMath(double math) {
		if(yuwen>100){
			System.out.println("成绩超出范围");
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
    		 System.out.println("成绩不能小于0");
    		 return -1;
    	 }else if(yingyu>100||yuwen>100||math>100){
    		 System.out.println("成绩超出范围");
    		 return -1;
    	 }else{
    	 average=(yuwen+yingyu+math)/3;
    	 System.out.println("平均成绩为："+average);
    	 return average;
    	 }
     }
}
