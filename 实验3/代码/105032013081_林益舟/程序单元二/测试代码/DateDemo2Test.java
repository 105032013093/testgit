package dsj.com_02;



import org.junit.Test;



public class DateDemo2Test {
	DateDemo2 dd=new DateDemo2();
	@Test
	public void test() {
		System.out.println("-------�ӿڲ���--------");
        System.out.println("DateDemo()�����yԇ�ɹ�");
        dd.dateDemo("2012-11-25");
        System.out.println();
        System.out.println("-------�߽���������--------");
    	  System.out.println("��������2015-11-20");
    	  dd.dateDemo("2015-11-20");
    	  System.out.println();
    	  	
	        System.out.println("-------�ݴ��Բ���--------");
	    	  System.out.println("��������11-18-20");
	    	   dd.dateDemo("11-18-20");
	}

}
