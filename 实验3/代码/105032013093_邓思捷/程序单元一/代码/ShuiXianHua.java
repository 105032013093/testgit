

import javax.print.attribute.standard.RequestingUserName;

public class ShuiXianHua {
    public boolean Flowa(int a,int b){
    	
    	if(b>1000) {
    	  	System.out.println("������Χ");
    	  	return false;
    	}
    	else if(a<0){
    		System.out.println("���ֲ���Ϊ����������������");
    		return false;
    	}
        System.out.println(a+"~"+b+"֮���ˮ�ɻ����ǣ�");
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
