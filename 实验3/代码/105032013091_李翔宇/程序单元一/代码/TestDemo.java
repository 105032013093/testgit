package demo;

public class TestDemo {
      private double money;
      private String username;
      private String password;
      private double interest;
      
      
      
      public double getMoney() {
		return money;
	}



	public void setMoney(double money) {
		this.money = money;
	}



	public String getUsername() {
		return username;
	}



	public void setUsername(String username) {
		this.username = username;
	}



	public String getPassword() {
		return password;
	}



	public void setPassword(String password) {
		this.password = password;
	}

     

	public double getInterest() {
		return interest;
	}



	public void setInterest(double interest) {
		this.interest = interest;
	}



	public void login(TestDemo td){
		String name=td.getUsername();
		String pword=td.getPassword();
		if(name!=null&&pword!=null){
			 if(name.equals("admin")&&pword.equals("123")){
				 System.out.println("登陆成功");
		    	  
			 }
		    	  else {
		    		  
		    		  System.out.println("密码错误");
				}
	} else{
		System.out.println("用户名或密码不能为空");
	 }
	}
	
	public void calculate(double money,double interest){
//		int i = 0;
		if(money<40){
			System.out.println("边界1");
		}else{
			System.out.println("边界2");
		}
//		for(i=0;i<40;i++){
//			money=money*(1+interest);
//		}
	}
	
    	 
    	  
}
    
