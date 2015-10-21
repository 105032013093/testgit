package com.imooc.util;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Ignore;
import org.junit.Test;

public class Annotation {
	

	/*ji
	 * @Test(expected=XXX.class)
	 *  @Test(timeout=毫秒)
	 *  @Ignore：所修饰的测试方法会被测试运行器忽略
	 *  @RunWith可以更改测试运行器
	 */
//    @Test(expected=ArithmeticException.class)
//	public void testDivide() {
//		// TODO Auto-generated method stub
//          assertEquals(3, new Calculate().divide(6, 0));
//	}
    
   
//    @Test(timeout=2000)
//    public void testWhile() {
//		// TODO Auto-generated method stub
//    	while(true){
//    		System.out.println("run forever....");
//    	}
//	}
    
    @Test(timeout=1000)
    public void testReadFile() {
		// TODO Auto-generated method stub
    	try {
			Thread.sleep(2000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
