package dsj.com_02;

public class DateDemo2 {
//	public static void main(String[] args) {
//		DateDemo2 dd=new DateDemo2();
//		dd.dateDemo("2015-18-11");
//	}
	public void dateDemo(String date) {
		String[] str = new String[3];
		str = date.split("-");
		int year = Integer.parseInt(str[0]);
		int month = Integer.parseInt(str[1]);
		int day = Integer.parseInt(str[2]);
		int Total = 0;
		int Leap = 0;

		switch (month) {
		case 1:
			Total = 0;
			break;
		case 2:
			Total = 31;
			break;
		case 3:
			Total = 59;
			break;
		case 4:
			Total = 90;
			break;
		case 5:
			Total = 120;
			break;
		case 6:
			Total = 151;
			break;
		case 7:
			Total = 181;
			break;
		case 8:
			Total = 212;
			break;
		case 9:
			Total = 242;
			break;
		case 10:
			Total = 273;
			break;
		case 11:
			Total = 303;
			break;
		case 12:
			Total = 334;
			break;
		default:
			System.out.println("输入的日期错误");
			break;
		}
		Total = Total + day;
		if (month > 2
				&& ((year % 4 == 0 && year % 100 != 0) || (year % 400) == 0)) {
			Leap = 1;
		}
		Total = Total + Leap;
		System.out.println("输入日期是该年的第" + Total + "天");
	}
}
