package dsj_01;

/**
 * 初始化数据
 * 
 * @author Deng
 * 
 */
public class Data {

	public Data() {
		str_goods_name = new String[50];
		dou_goods_price = new double[50];
		int_cust_no = new int[100];
		str_cust_birth = new String[100];
		int_cust_score = new int[100];
		man_manager = new Manager();
	}

	public void ini() {
		str_goods_name[0] = "addidas运动鞋";
		dou_goods_price[0] = 880D;
		str_goods_name[1] = "Kappa网球裙";
		dou_goods_price[1] = 200D;
		str_goods_name[2] = "网球拍";
		dou_goods_price[2] = 780D;
		str_goods_name[3] = "addidasT恤";
		dou_goods_price[3] = 420.77999999999997D;
		str_goods_name[4] = "Nike运动鞋";
		dou_goods_price[4] = 900D;
		str_goods_name[5] = "Kappa网球";
		dou_goods_price[5] = 45D;
		str_goods_name[6] = "KappaT恤";
		dou_goods_price[6] = 245D;
		int_cust_no[0] = 1900;
		str_cust_birth[0] = "08/05";
		int_cust_score[0] = 2000;
		int_cust_no[1] = 1711;
		str_cust_birth[1] = "07/13";
		int_cust_score[1] = 4000;
		int_cust_no[2] = 1623;
		str_cust_birth[2] = "06/26";
		int_cust_score[2] = 5000;
		int_cust_no[3] = 1545;
		str_cust_birth[3] = "04/08";
		int_cust_score[3] = 2200;
		int_cust_no[4] = 1464;
		str_cust_birth[4] = "08/16";
		int_cust_score[4] = 1000;
		int_cust_no[5] = 1372;
		str_cust_birth[5] = "12/23";
		int_cust_score[5] = 3000;
		int_cust_no[6] = 1286;
		str_cust_birth[6] = "12/21";
		int_cust_score[6] = 10080;
	}

	public String str_goods_name[];
	public double dou_goods_price[];
	public int int_cust_no[];
	public String str_cust_birth[];
	public int int_cust_score[];
	public Manager man_manager;
}