package 数组查找;

public class ArrayDemo {

	/*
	 * 返回值类型：int 参数列表：数组，被查找的元素
	 */
	public static int getIndex(int[] arr, int value) {
		if(arr.length>9){
			System.out.println("数字超出范围....");
		}
		// 定义索引
		int max = arr.length - 1;
		int min = 0;
		int mid = (max + min) / 2;

		// 先判断一次
		while (arr[mid] != value) {
			if (arr[mid] > value) {
				max = mid - 1;
			} else if (arr[mid] < value) {
				min = mid + 1;
			}

			// 记得判断一次min要小于max
			if (min > max) {
				System.out.println("数字不存在.....");
//				break;
				return -1;
			}

			// 重新计算mid
			mid = (min + max) / 2;
		}
        System.out.println("该数字在第"+mid+"个位置");
		return mid;
	}
}
