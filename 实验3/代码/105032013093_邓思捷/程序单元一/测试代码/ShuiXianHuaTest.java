import static org.junit.Assert.*;

import org.junit.Test;



public class ShuiXianHuaTest {

	@Test
	public void test() {
		 ShuiXianHua mu = new ShuiXianHua();
		 boolean flag=mu.Flowa(7,478);
		    boolean flag1=mu.Flowa(300, 10000);
		    boolean flag2=mu.Flowa(-100, 100);
	}

}
