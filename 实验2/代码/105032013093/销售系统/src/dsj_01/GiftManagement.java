package dsj_01;

import java.util.Scanner;

/**
 * ���������
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
		System.out.print("\n\n�밴'n'������һ���˵�:");
		Scanner scanner = new Scanner(System.in);
		boolean flag = true;
		do
			if (scanner.next().equals("n")) {
				Menu menu = new Menu();
				menu.setData(str_goods_name, dou_goods_price, int_cust_no,
						str_cust_birth, int_cust_score);
				menu.showSendGMenu();
			} else {
				System.out.print("�������, ������'n'������һ���˵���");
				flag = false;
			}
		while (!flag);
	}

	public void sendBirthCust() {
		System.out.println("�������ϵͳ > �����ʺ�\n\n");
		System.out.print("��������������(��/��<����λ��ʾ>)��");
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
			System.out.println("�����յĻ�Ա�ǣ�");
			System.out.println(s1);
			System.out.println("��ϲ������MP3һ����");
		} else {
			System.out.println("����û�й����յĻ�Ա��");
		}
		returnLastMenu();
	}

	public void sendLuckyCust() {
		System.out.println("�������ϵͳ > ���˳齱\n\n");
		System.out.print("�Ƿ�ʼ��y/n����");
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
				System.out.println((new StringBuilder()).append("���˿ͻ�����MP3��")
						.append(s).toString());
			else
				System.out.println("�����˿ͻ���");
		}
		returnLastMenu();
	}

	public void sendGoldenCust() {
		System.out.println("�������ϵͳ > ���˴����\n\n");
		int i = 0;
		int j = int_cust_score[0];
		for (int k = 0; k < int_cust_score.length && int_cust_score[k] != 0; k++)
			if (int_cust_score[k] > j) {
				j = int_cust_score[k];
				i = k;
			}

		System.out.println((new StringBuilder()).append("������߻��ֵĻ�Ա�ǣ� ")
				.append(int_cust_no[i]).append("\t").append(str_cust_birth[i])
				.append("\t").append(int_cust_score[i]).toString());
		Gift gift = new Gift();
		gift.str_name = "ƻ���ʼǱ�����";
		gift.dou_price = 12000D;
		System.out.print("��ϲ��������Ʒ�� ");
		System.out.println(gift);
		returnLastMenu();
	}

	public String str_goods_name[];
	public double dou_goods_price[];
	public int int_cust_no[];
	public String str_cust_birth[];
	public int int_cust_score[];
}