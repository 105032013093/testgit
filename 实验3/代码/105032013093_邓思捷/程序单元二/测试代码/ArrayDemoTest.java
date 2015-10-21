package 数组查找;

import static org.junit.Assert.*;

import org.junit.Test;

public class ArrayDemoTest {

	@Test
	public void testGetIndex() {
		        ArrayDemo ad=new ArrayDemo();
		         // 定义数组
				int[] arr = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
				int[] arr1 = { 11, 34,45,67,34,78,89,23,90,37 };	
				int[] arr2 = { 11, 34,45,67,34,78,89,23};
				// 功能
				ad. getIndex(arr, 88);
				ad. getIndex(arr1, 34);
				ad. getIndex(arr2, 250);
//				System.out.println(index);

//				index = ad.getIndex(arr, 22);
//				System.out.println(index);

//				index =ad.getIndex(arr, 250);
//				System.out.println(index);
	}

}
