package demo;

import static org.junit.Assert.*;

import org.junit.Test;

public class TestDemoTest {

	@Test
	public void testLogin() {
		TestDemo td=new TestDemo();
		td.setUsername("admin");
		td.setPassword("1234567");
//		td.setMoney(50);
//		td.setInterest(0.25);
		td.login(td);
	}

//	@Test
//	public void testCalculate() {
//		TestDemo td=new TestDemo();
//		td.calculate(50, 0.25);
//	}

}
