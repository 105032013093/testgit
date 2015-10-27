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
		System.out.print("\n\n�밴'n'������һ���˵�:");
		Scanner scanner = new Scanner(System.in);
		boolean flag = true;
		do
			if (scanner.next().equals("n")) {
				Menu menu = new Menu();
				menu.setData(str_goods_name, dou_goods_price, int_cust_no,
						str_cust_birth, intcust_score);
				menu.showCustMMenu();
			} else {
				System.out.print("�������, ������'n'������һ���˵���");
				flag = false;
			}
		while (!flag);
	}

	public void add() {
		System.out.println("�������ϵͳ > �ͻ���Ϣ���� > ��ӿͻ���Ϣ\n\n");
		Scanner scanner = new Scanner(System.in);
		System.out.print("�������Ա��(<4λ����>)��");
		int i = scanner.nextInt();
		System.out.print("�������Ա���գ���/��<����λ����ʾ>����");
		String s = scanner.next();
		System.out.print("��������֣�");
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
		System.out.println("�»�Ա��ӳɹ���");
		returnLastMenu();
	}

	public void modify() {
		System.out.println("�������ϵͳ > �ͻ���Ϣ���� > �޸Ŀͻ���Ϣ\n\n");
		System.out.print("�������Ա�ţ�");
		Scanner scanner = new Scanner(System.in);
		int i = scanner.nextInt();
		System.out.println("  ��Ա��            ����             ����      ");
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
			System.out.println("\t\t\t\t1.�� �� �� Ա �� ��.\n");
			System.out.println("\t\t\t\t2.�� �� �� Ա �� ��.\n");
			System.out
					.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
			System.out.print("��ѡ���������֣�");
			switch (scanner.nextInt()) {
			case 1: // '\001'
				System.out.print("�������޸ĺ�����գ�");
				str_cust_birth[j] = scanner.next();
				System.out.println("������Ϣ�Ѹ��ģ�");
				break;

			case 2: // '\002'
				System.out.print("�������޸ĺ�Ļ�Ա���֣�");
				intcust_score[j] = scanner.nextInt();
				System.out.println("��Ա�����Ѹ��ģ�");
				break;
			}
		} else {
			System.out.println("��Ǹ��û�����ѯ�Ļ�Ա��");
		}
		returnLastMenu();
	}

	public void search() {
		System.out.println("�������ϵͳ > �ͻ���Ϣ���� > ��ѯ�ͻ���Ϣ\n");
		String s = "y";
		Scanner scanner = new Scanner(System.in);
		for (; s.equals("y"); s = scanner.next()) {
			System.out.print("�������Ա�ţ�");
			int i = scanner.nextInt();
			System.out.println("  ��Ա��            ����             ����      ");
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
				System.out.println("��Ǹ��û�����ѯ�Ļ�Ա��Ϣ��");
			System.out.print("\nҪ������ѯ��y/n��:");
		}

		returnLastMenu();
	}

	public void show() {
		System.out.println("�������ϵͳ > �ͻ���Ϣ���� > ��ʾ�ͻ���Ϣ\n\n");
		System.out.println("  ��Ա��            ����             ����      ");
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