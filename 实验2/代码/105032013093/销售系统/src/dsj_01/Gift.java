package dsj_01;

/**
 * ������
 * 
 * @author Deng
 */
public class Gift {

	public Gift() {
	}

	public String toString() {
		return (new StringBuilder()).append("һ����ֵ��").append(dou_price).append("��")
				.append(str_name).toString();
	}

	public String str_name;
	public double dou_price;
}