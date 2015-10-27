package Æ½¾ù³É¼¨;

import static org.junit.Assert.*;

import org.junit.Test;

public class AvgTest {

	@Test
	public void test() {
		Avg avg=new Avg();
		
		avg.avg(98, 37, 68);
		avg.avg(98, 37, 102);
		avg.avg(-67, -90, 68);
	}

}
