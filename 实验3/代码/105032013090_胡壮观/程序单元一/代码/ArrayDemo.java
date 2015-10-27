package 选择排序;

public class ArrayDemo {
//	public static void main(String[] args) {
//		
//
//	}
	
	public void sort(int[] arr){
		if(arr.length>8){
			System.out.println("数组太大，超出范围");
		}else{
		for (int x = 0; x < arr.length - 1; x++) {
			for (int y = x + 1; y < arr.length; y++) {
				if (arr[y] < arr[x]) {
					int temp = arr[x];
					arr[x] = arr[y];
					arr[y] = temp;
				}
			}
		}
		}
	}

	public static void printArray(int[] arr) {
		System.out.print("[");
		for (int x = 0; x < arr.length; x++) {
			if (x == arr.length - 1) {
				System.out.print(arr[x]);
			} else {
				System.out.print(arr[x] + ", ");
			}
		}
		System.out.println("]");
	}
}
