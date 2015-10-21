package —°‘Ò≈≈–Ú;

import static org.junit.Assert.*;

import org.junit.Test;

public class ArrayDemoTest {

	@Test
	public void testSort() {
		int[] arr={24, 69, 80, 57, 13};
		int[] arr1={24, 69, 80, 57, 13,77,88,68,46};
		int[] arr2={24, -69, -80, 57};
		System.out.println("≈≈–Ú«∞£∫");
		ArrayDemo ad=new ArrayDemo();
		ad.printArray(arr);
		ad.sort(arr);
		System.out.println("≈≈–Ú∫Û£∫");
		ad.printArray(arr);
		System.out.println("===================================");
		ad.sort(arr1);
		System.out.println("===================================");
		System.out.println("≈≈–Ú«∞£∫");
//		ArrayDemo ad=new ArrayDemo();
		ad.printArray(arr2);
		ad.sort(arr2);
		System.out.println("≈≈–Ú∫Û£∫");
		ad.printArray(arr2);
	}

//	@Test
//	public void testPrintArray() {
//		fail("Not yet implemented");
//	}

}
