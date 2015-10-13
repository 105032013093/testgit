package com.nd.htp.servlets;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.nd.htp.dataOperator.ConnectSelect;
import com.nd.htp.dataOperator.ConnectUpdate;
import com.nd.htp.json.JSONObject;

/**
 * Servlet implementation class OrderServlets
 */
@WebServlet("/OrderServlets")
public class OrderServlets extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private int parkingnumber;
	private int freeparking;
	private int carportId;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public OrderServlets() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		request.setCharacterEncoding("utf-8");
		response.setCharacterEncoding("utf-8");
		response.setContentType("text/html; charset=utf-8");
		//获取手机端发来的请求信息
		parkingnumber=Integer.parseInt(request.getParameter("parkingnumber"));
		carportId=Integer.parseInt(request.getParameter("carportId"));
		//连接到数据库获取freeparking
		ResultSet resultSet = null;
		Connection connection = null;
		Statement statement = null;
		 int resultSet2 = 0;
		 PreparedStatement ps = null;
		try {
			String sql = "select freeparking from carport where carportId="+String.valueOf(carportId);
			resultSet = ConnectSelect.conn_mysql(sql, connection, statement,
					resultSet);
//			JSONObject object = new JSONObject();
//			String usernameServer, passwordServer;
//			int freeparkingServer;
//			while (resultSet.next()) {
				freeparking = resultSet.getInt("freeparking");
				if(parkingnumber<=freeparking){
					//输出流（手机和pc）---预订成功
					response.getOutputStream().write("预订成功".getBytes("utf-8"));
					freeparking=freeparking-parkingnumber;
			        	 String sql2="updata carport set freeparking="+String.valueOf(freeparking)
			        			 +"where carpotId="+String.valueOf(carportId);
			        	
			          
					resultSet2=ConnectUpdate.coon_update(sql2, connection,
							ps);
					//发给PC端
					
					
					
				}else{
					//输出流(手机)---仅剩**个车位
					String order_false="预订失败，仅剩"+freeparking+"个车位";
					response.getOutputStream().write(order_false.getBytes("utf-8"));
					
				}
//				System.out.println(usernameServer + "\t" + passwordServer
//						+ "\n");
//				if (username.equals(usernameServer)
//						& password.equals(passwordServer)) {
//					object.put("success", "��¼�ɹ�");
//					object.put("user_id", resultSet.getString("userId"));
//					tap = false;
//					break;
//				}
//			}
			
//			} else {
//				response.getOutputStream().write(
//						(object.toString()).getBytes("utf-8"));
//			}
//			resultSet.close();
//			statement.close();
//			connection.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		
		
	
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		super.doGet(request, response);
	}

}
