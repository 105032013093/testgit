package dsj_01;

import java.util.Scanner;

/**
 * ���︶��
 * 
 * @author Deng
 * 
 */
public class Pay {

	public Pay() {
	}

	public void setData(String as[], double ad[], int ai[], String as1[],
			int ai1[]) {
		str_goods_name = as;
		dou_goods_price = ad;
		int_cust_no = ai;
		str_cust_birth = as1;
		int_cust_score = ai1;
	}

	public double getDiscount(int i, int ai[], int ai1[]) {
		int j = -1;
		int k = 0;
		do {
			if (k >= ai.length)
				break;
			if (i == ai[k]) {
				j = k;
				break;
			}
			k++;
		} while (true);
		double d;
		if (ai1[j] < 1000)
			d = 0.94999999999999996D;
		else if (1000 <= ai1[j] && ai1[j] < 2000)
			d = 0.90000000000000002D;
		else if (2000 <= ai1[j] && ai1[j] < 3000)
			d = 0.84999999999999998D;
		else if (3000 <= ai1[j] && ai1[j] < 4000)
			d = 0.80000000000000004D;
		else if (4000 <= ai1[j] && ai1[j] < 6000)
			d = 0.75D;
		else if (6000 <= ai1[j] && ai1[j] < 8000)
			d = 0.69999999999999996D;
		else
			d = 0.59999999999999998D;
		return d;
	}

	public void calcPrice() {
		String s2 = "";
		double d1 = 0.0D;
		double d2 = 0.0D;
		System.out.println("�������ϵͳ > �������\n\n");
		System.out.println("*************************************");
		System.out.println("��ѡ�������Ʒ��ţ�");
		int l = 0;
		double d4 = 0;
		for (; l < str_goods_name.length && str_goods_name[l] != null; l++) {
			d4++;
			System.out.println((new StringBuilder()).append(d4).append(": ")
					.append(str_goods_name[l]).append("\t").toString());
		}

		System.out.println("*************************************\n");
		Scanner scanner = new Scanner(System.in);
		System.out.print("\t�������Ա�ţ�");
		int i = scanner.nextInt();
		d4 = getDiscount(i, int_cust_no, int_cust_score);
		String s1;
		do {
			System.out.print("\t��������Ʒ��ţ�");
			int j = scanner.nextInt();
			System.out.print("\t��������Ŀ��");
			int k = scanner.nextInt();
			double d = dou_goods_price[j - 1];
			String s = str_goods_name[j - 1];
			d1 += d * (double) k;
			s2 = (new StringBuilder()).append(s2).append("\n").append(s)
					.append("\t").append("��").append(d).append("\t\t")
					.append(k).append("\t\t").append("��")
					.append(d * (double) k).append("\t").toString();
			System.out.print("\t�Ƿ������y/n��");
			s1 = scanner.next();
		} while (s1.equals("y"));
		d2 = d1 * d4;
		System.out.println("\n");
		System.out.println("���������������������������������������嵥������������������������������������������");
		System.out.println("��Ʒ\t\t����\t\t����\t\t���\t");
		System.out.print(s2);
		System.out.println((new StringBuilder()).append("\n�ۿۣ�\t").append(d4)
				.toString());
		System.out.println((new StringBuilder()).append("����ܼ�:\t��").append(d2)
				.toString());
		System.out.print("ʵ�ʽ���:\t��");
		double d3 = scanner.nextDouble();
		System.out.println((new StringBuilder()).append("��Ǯ:\t��")
				.append(d3 - d2).toString());
		int i1 = ((int) d2 / 100) * 3;
		int j1 = 0;
		do {
			if (j1 >= int_cust_no.length)
				break;
			if (int_cust_no[j1] == i) {
				int_cust_score[j1] = int_cust_score[j1] + i1;
				System.out.println((new StringBuilder()).append("���ι�������Ļ����ǣ� ")
						.append(i1).toString());
				break;
			}
			j1++;
		} while (true);
		System.out.print("\n��'n'������һ���˵�:");
		if (scanner.next().equals("n")) {
			Menu menu = new Menu();
			menu.setData(str_goods_name, dou_goods_price, int_cust_no,
					str_cust_birth, int_cust_score);
			menu.showMainMenu();
		}
	}

	public String str_goods_name[];
	public double dou_goods_price[];
	public int int_cust_no[];
	public String str_cust_birth[];
	public int int_cust_score[];
}