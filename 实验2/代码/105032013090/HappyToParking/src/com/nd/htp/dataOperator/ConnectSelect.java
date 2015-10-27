package com.nd.htp.dataOperator;

import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;

public class ConnectSelect {
	public static ResultSet conn_mysql(String sql, Connection connection,
			Statement statement, ResultSet resultSet) {

		try {

			String url = "jdbc:mysql://localhost:3306/parkingquery";
			try {
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				connection = DriverManager.getConnection(url, "root", "");
				System.out.println("数据加载中————————");
			} catch (Exception e) {
				e.printStackTrace();
			}
			statement = connection.createStatement();
			resultSet = statement.executeQuery(sql);
            System.out.println(resultSet);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return resultSet;

	}
}
