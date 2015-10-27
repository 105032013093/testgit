

import javax.print.attribute.standard.RequestingUserName;

public class ShuiXianHua {
    public boolean Flowa(int a,int b){
    	
    	if(b>1000) {
    	  	System.out.println("超出范围");
    	  	return false;
    	}
    	else if(a<0){
    		System.out.println("数字不能为负数，请重新输入");
    		return false;
    	}
        System.out.println(a+"~"+b+"之间的水仙花数是：");
        for(int custNo=a;custNo<=b;custNo++){
            int geWei=custNo%10;
            int shiWei=custNo/10%10;
            int baiWei=custNo/100%10;
            if(custNo==geWei*geWei*geWei+shiWei*shiWei*shiWei+baiWei*baiWei*baiWei){
                System.out.println(custNo);
            }
        } return true;
    }
   
}
