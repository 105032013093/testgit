package dsj_01;

import java.util.Scanner;

/**
 * 系统开启类
 * 
 * @author Deng
 * 
 */
public class StartSMS {

	public StartSMS() {
	}

	public static void main(String args[]) {
		Data data = new Data();
		data.ini();
		Menu menu = new Menu();
		menu.setData(data.str_goods_name, data.dou_goods_price, data.int_cust_no,
				data.str_cust_birth, data.int_cust_score);
		menu.showLoginMenu();
		boolean flag = true;
		label0: do {
			if (!flag)
				break;
			Scanner scanner = new Scanner(System.in);
			int i = scanner.nextInt();
			VerifyEqual verifyequal = new VerifyEqual();
			switch (i) {
			case 1: 
				int j = 3;
				do {
					if (j < 1)
						continue label0;
					if (verifyequal.verify(data.man_manager.str_username,
							data.man_manager.str_password)) {
						menu.showMainMenu();
						continue label0;
					}
					if (j != 1) {
						System.out.println("\n用户名和密码不匹配，请重新输入：");
					} else {
						System.out.println("\n您没有权限进入系统！谢谢！");
						flag = false;
					}
					j--;
				} while (true);

			case 2: 
				if (verifyequal.verify(data.man_manager.str_username,
						data.man_manager.str_password)) {
					System.out.print("请输入新的用户名：");
					data.man_manager.str_username = scanner.next();
					System.out.print("请输入新的密码：");
					data.man_manager.str_password = scanner.next();
					System.out.println("用户名和密码已更改！");
					System.out.println("\n请选择，输入数字：");
				} else {
					System.out.println("抱歉，你没有权限修改！");
					flag = false;
				}
				break;

			case 3: 
				System.out.println("谢谢您的使用！");
				System.exit(0);
				break;

			default:
				System.out.print("\n输入有误！请重新选择，输入数字: ");
				break;
			}
		} while (flag);
	}
}