package dsj_01;

import java.util.Scanner;

public class CustManagement {

	public CustManagement() {
	}

	public void setData(String as[], double ad[], int ai[], String as1[],
			int ai1[]) {
		str_goods_name = as;
		dou_goods_price = ad;
		int_cust_no = ai;
		str_cust_birth = as1;
		intcust_score = ai1;
	}

	public void returnLastMenu() {
		System.out.print("\n\n请按'n'返回上一级菜单:");
		Scanner scanner = new Scanner(System.in);
		boolean flag = true;
		do
			if (scanner.next().equals("n")) {
				Menu menu = new Menu();
				menu.setData(str_goods_name, dou_goods_price, int_cust_no,
						str_cust_birth, intcust_score);
				menu.showCustMMenu();
			} else {
				System.out.print("输入错误, 请重新'n'返回上一级菜单：");
				flag = false;
			}
		while (!flag);
	}

	public void add() {
		System.out.println("购物管理系统 > 客户信息管理 > 添加客户信息\n\n");
		Scanner scanner = new Scanner(System.in);
		System.out.print("请输入会员号(<4位整数>)：");
		int i = scanner.nextInt();
		System.out.print("请输入会员生日（月/日<用两位数表示>）：");
		String s = scanner.next();
		System.out.print("请输入积分：");
		int j = scanner.nextInt();
		int k = -1;
		int l = 0;
		do {
			if (l >= int_cust_no.length)
				break;
			if (int_cust_no[l] == 0) {
				k = l;
				break;
			}
			l++;
		} while (true);
		int_cust_no[k] = i;
		str_cust_birth[k] = s;
		intcust_score[k] = j;
		System.out.println("新会员添加成功！");
		returnLastMenu();
	}

	public void modify() {
		System.out.println("购物管理系统 > 客户信息管理 > 修改客户信息\n\n");
		System.out.print("请输入会员号：");
		Scanner scanner = new Scanner(System.in);
		int i = scanner.nextInt();
		System.out.println("  会员号            生日             积分      ");
		System.out.println("------------|------------|---------------");
		int j = -1;
		int k = 0;
		do {
			if (k >= int_cust_no.length)
				break;
			if (int_cust_no[k] == i) {
				System.out.println((new StringBuilder()).append(int_cust_no[k])
						.append("\t\t").append(str_cust_birth[k])
						.append("\t\t").append(intcust_score[k]).toString());
				j = k;
				break;
			}
			k++;
		} while (true);
		if (j != -1) {
			System.out
					.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
			System.out.println("\t\t\t\t1.修 改 会 员 生 日.\n");
			System.out.println("\t\t\t\t2.修 改 会 员 积 分.\n");
			System.out
					.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
			System.out.print("请选择，输入数字：");
			switch (scanner.nextInt()) {
			case 1: // '\001'
				System.out.print("请输入修改后的生日：");
				str_cust_birth[j] = scanner.next();
				System.out.println("生日信息已更改！");
				break;

			case 2: // '\002'
				System.out.print("请输入修改后的会员积分：");
				intcust_score[j] = scanner.nextInt();
				System.out.println("会员积分已更改！");
				break;
			}
		} else {
			System.out.println("抱歉，没有你查询的会员。");
		}
		returnLastMenu();
	}

	public void search() {
		System.out.println("购物管理系统 > 客户信息管理 > 查询客户信息\n");
		String s = "y";
		Scanner scanner = new Scanner(System.in);
		for (; s.equals("y"); s = scanner.next()) {
			System.out.print("请输入会员号：");
			int i = scanner.nextInt();
			System.out.println("  会员号            生日             积分      ");
			System.out.println("------------|------------|---------------");
			boolean flag = false;
			int j = 0;
			do {
				if (j >= int_cust_no.length)
					break;
				if (int_cust_no[j] == i) {
					System.out.println((new StringBuilder())
							.append(int_cust_no[j]).append("\t\t")
							.append(str_cust_birth[j]).append("\t\t")
							.append(intcust_score[j]).toString());
					flag = true;
					break;
				}
				j++;
			} while (true);
			if (!flag)
				System.out.println("抱歉，没有你查询的会员信息。");
			System.out.print("\n要继续查询吗（y/n）:");
		}

		returnLastMenu();
	}

	public void show() {
		System.out.println("购物管理系统 > 客户信息管理 > 显示客户信息\n\n");
		System.out.println("  会员号            生日             积分      ");
		System.out.println("------------|------------|---------------");
		int i = int_cust_no.length;
		for (int j = 0; j < i && int_cust_no[j] != 0; j++)
			System.out.println((new StringBuilder()).append(int_cust_no[j])
					.append("\t\t").append(str_cust_birth[j]).append("\t\t")
					.append(intcust_score[j]).toString());

		returnLastMenu();
	}

	public String str_goods_name[];
	public double dou_goods_price[];
	public int int_cust_no[];
	public String str_cust_birth[];
	public int intcust_score[];
}