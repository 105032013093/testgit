package com.imooc.util;

import static org.junit.Assert.*;

import org.junit.Test;

public class CalculateTest {

	/*
	 * 1.���Է��� �ϱ���ʹ��@Test��������
	 * 2.���Է�������ʹ��public void�������Σ����ܴ��κεĲ���
	 * 3.�½�һ��Դ����Ŀ¼��������ǵĴ���
	 * 4.������İ�Ӧ�úͱ������ౣ��һ��
	 * 5.���Ե�Ԫ�е�ÿ�����Է������Զ������ԣ����Է���֮�䲻�����κ�����
	 * 6.������ʹ��Test��Ϊ�����ĺ�׺�����Ǳ��룩
	 * 7.���Է���ʹ��test��Ϊ��������ǰ׺�����Ǳ��룩
	 */
	
	/*
	 * 1.failure��˵�����������������Ԥ�ڵĲ�һ��
	 * 2.error���д����쳣����ģ��������ǲ����ڲ��Դ��뱾��Ĵ���
	 * Ҳ�����Ǳ����Դ����е�һ�����ص�bug
	 * 3.����������������֤�����ǶԵģ���������֤����û�д�
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
