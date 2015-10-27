package dsj_01;

import java.util.Scanner;

/**
 * 礼物管理类
 * 
 * @author Deng
 * 
 */
public class GiftManagement {

	public GiftManagement() {
	}

	public void setData(String as[], double ad[], int ai[], String as1[],
			int ai1[]) {
		str_goods_name = as;
		dou_goods_price = ad;
		int_cust_no = ai;
		str_cust_birth = as1;
		int_cust_score = ai1;
	}

	public void returnLastMenu() {
		System.out.print("\n\n请按'n'返回上一级菜单:");
		Scanner scanner = new Scanner(System.in);
		boolean flag = true;
		do
			if (scanner.next().equals("n")) {
				Menu menu = new Menu();
				menu.setData(str_goods_name, dou_goods_price, int_cust_no,
						str_cust_birth, int_cust_score);
				menu.showSendGMenu();
			} else {
				System.out.print("输入错误, 请重新'n'返回上一级菜单：");
				flag = false;
			}
		while (!flag);
	}

	public void sendBirthCust() {
		System.out.println("购物管理系统 > 生日问候\n\n");
		System.out.print("请输入今天的日期(月/日<用两位表示>)：");
		Scanner scanner = new Scanner(System.in);
		String s = scanner.next();
		System.out.println(s);
		String s1 = "";
		boolean flag = false;
		for (int i = 0; i < str_cust_birth.length; i++)
			if (str_cust_birth[i] != null && str_cust_birth[i].equals(s)) {
				s1 = (new StringBuilder()).append(s1).append(int_cust_no[i])
						.append("\n").toString();
				flag = true;
			}

		if (flag) {
			System.out.println("过生日的会员是：");
			System.out.println(s1);
			System.out.println("恭喜！获赠MP3一个！");
		} else {
			System.out.println("今天没有过生日的会员！");
		}
		returnLastMenu();
	}

	public void sendLuckyCust() {
		System.out.println("购物管理系统 > 幸运抽奖\n\n");
		System.out.print("是否开始（y/n）：");
		Scanner scanner = new Scanner(System.in);
		if (scanner.next().equals("y")) {
			int i = (int) (Math.random() * 10D);
			boolean flag = false;
			String s = "";
			for (int k = 0; k < int_cust_no.length && int_cust_no[k] != 0; k++) {
				int j = (int_cust_no[k] / 100) % 10;
				if (j == i) {
					s = (new StringBuilder()).append(s).append(int_cust_no[k])
							.append("\t").toString();
					flag = true;
				}
			}

			if (flag)
				System.out.println((new StringBuilder()).append("幸运客户获赠MP3：")
						.append(s).toString());
			else
				System.out.println("无幸运客户。");
		}
		returnLastMenu();
	}

	public void sendGoldenCust() {
		System.out.println("购物管理系统 > 幸运大放送\n\n");
		int i = 0;
		int j = int_cust_score[0];
		for (int k = 0; k < int_cust_score.length && int_cust_score[k] != 0; k++)
			if (int_cust_score[k] > j) {
				j = int_cust_score[k];
				i = k;
			}

		System.out.println((new StringBuilder()).append("具有最高积分的会员是： ")
				.append(int_cust_no[i]).append("\t").append(str_cust_birth[i])
				.append("\t").append(int_cust_score[i]).toString());
		Gift gift = new Gift();
		gift.str_name = "苹果笔记本电脑";
		gift.dou_price = 12000D;
		System.out.print("恭喜！获赠礼品： ");
		System.out.println(gift);
		returnLastMenu();
	}

	public String str_goods_name[];
	public double dou_goods_price[];
	public int int_cust_no[];
	public String str_cust_birth[];
	public int int_cust_score[];
}