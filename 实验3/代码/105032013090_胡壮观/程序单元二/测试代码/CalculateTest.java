package com.imooc.util;

import static org.junit.Assert.*;

import org.junit.Test;

public class CalculateTest {

	/*
	 * 1.测试方法 上必须使用@Test进行修饰
	 * 2.测试方法必须使用public void进行修饰，不能带任何的参数
	 * 3.新建一个源代码目录来存放我们的代码
	 * 4.测试类的包应该和被测试类保持一致
	 * 5.测试单元中的每个测试方法可以独立测试，测试方法之间不能有任何依赖
	 * 6.测试类使用Test作为类名的后缀（不是必须）
	 * 7.测试方法使用test作为方法名的前缀（不是必须）
	 */
	
	/*
	 * 1.failure是说程序的输出结果和我们预期的不一样
	 * 2.error是有代码异常引起的，它可以是产生于测试代码本身的错误，
	 * 也可能是被测试代码中的一个隐藏的bug
	 * 3.测试用例不是用来证明你是对的，而是用来证明你没有错
	 */
	
//	@Test
//	public void add() {
//		assertEquals(6,new Calculate().add(3, 3));
//	
//	}
	@Test
	public void divide() {
		assertEquals(6,new Calculate().divide(3, 0));
	
	}


}
