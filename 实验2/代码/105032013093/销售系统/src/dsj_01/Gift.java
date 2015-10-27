package dsj_01;

/**
 * 礼物类
 * 
 * @author Deng
 */
public class Gift {

	public Gift() {
	}

	public String toString() {
		return (new StringBuilder()).append("一个价值￥").append(dou_price).append("的")
				.append(str_name).toString();
	}

	public String str_name;
	public double dou_price;
}