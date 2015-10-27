package com.nd.htp.dataOperator;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

public class ConnectUpdate {
	public static int coon_update(String sql, Connection connection,
			PreparedStatement ps) {

		try {

			String url = "jdbc:mysql://localhost:3306/parkingquery";
			try {
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				connection = DriverManager.getConnection(url, "root", "");
				System.out.println("数据加载中————————");
			} catch (Exception e) {
				e.printStackTrace();
			}
			ps = connection.prepareStatement(sql);
			int result = ps.executeUpdate(sql);
			return result;
		} catch (Exception e) {
			e.printStackTrace();
			return 0;
		}

	}
}
