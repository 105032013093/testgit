package 兔子递归;

public class RabbitDemo {
	public static void main(String[] args) {
		// 数组
		int[] arr = new int[20];
		arr[0] = 1;
		arr[1] = 1;
		/*
		arr[2] = arr[0] + arr[1];
		arr[3] = arr[1] + arr[2];
		arr[4] = arr[2] + arr[3];
		...
		*/
		for(int x=2; x<arr.length; x++){
			arr[x] = arr[x-2] + arr[x-1];
		}
		
		System.out.println(arr[19]);
		
		//变量的交换
		int a = 1;
		int b = 1;
		for(int x=0; x<18; x++){
			int temp = a;
			a = b;
			b = temp + b;
		}
		System.out.println(b);
	}
}
