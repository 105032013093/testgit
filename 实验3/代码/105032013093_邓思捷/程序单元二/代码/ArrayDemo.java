package �������;

public class ArrayDemo {

	/*
	 * ����ֵ���ͣ�int �����б����飬�����ҵ�Ԫ��
	 */
	public static int getIndex(int[] arr, int value) {
		if(arr.length>9){
			System.out.println("���ֳ�����Χ....");
		}
		// ��������
		int max = arr.length - 1;
		int min = 0;
		int mid = (max + min) / 2;

		// ���ж�һ��
		while (arr[mid] != value) {
			if (arr[mid] > value) {
				max = mid - 1;
			} else if (arr[mid] < value) {
				min = mid + 1;
			}

			// �ǵ��ж�һ��minҪС��max
			if (min > max) {
				System.out.println("���ֲ�����.....");
//				break;
				return -1;
			}

			// ���¼���mid
			mid = (min + max) / 2;
		}
        System.out.println("�������ڵ�"+mid+"��λ��");
		return mid;
	}
}
