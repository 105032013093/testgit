package dsj.com_02;



import org.junit.Test;



public class DateDemo2Test {
	DateDemo2 dd=new DateDemo2();
	@Test
	public void test() {
		System.out.println("-------接口测试--------");
        System.out.println("DateDemo()方法測試成功");
        dd.dateDemo("2012-11-25");
        System.out.println();
        System.out.println("-------边界条件测试--------");
    	  System.out.println("输入日期2015-11-20");
    	  dd.dateDemo("2015-11-20");
    	  System.out.println();
    	  	
	        System.out.println("-------容错性测试--------");
	    	  System.out.println("输入日期11-18-20");
	    	   dd.dateDemo("11-18-20");
	}

}
