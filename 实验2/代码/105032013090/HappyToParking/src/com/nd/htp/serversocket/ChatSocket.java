package com.nd.htp.serversocket;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;
import java.net.Socket;

import javax.swing.JOptionPane;

public class ChatSocket extends Thread {
	private Socket socket;
	private int result;
	
	public ChatSocket(Socket s){
		this.socket = s;
		
	}
	
	public void out(String out) {
		try {
			socket.getOutputStream().write((out+"\n").getBytes("UTF-8"));
		} catch (UnsupportedEncodingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			System.out.println("断开了一个客户端链接");			
			e.printStackTrace();
		}
	}

	@Override
	public void run() {
		out("你已经连接到本服务器了");
		try {
			BufferedReader br = new BufferedReader(
					new InputStreamReader(
							socket.getInputStream(),"UTF-8"));
			String line = null;
			while ((line = br.readLine()) != null) {
				System.out.println(line);
				result=JOptionPane.showConfirmDialog(null,"剩余车位：23\n***预订2个车位","****的订单", JOptionPane.PLAIN_MESSAGE);
				if(result==0){
				out("停车场已接单");
				}
				
			}
			br.close();
			System.out.println("断开了一个客户端链接");
			
		} catch (UnsupportedEncodingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			System.out.println("断开了一个客户端链接");
			
			e.printStackTrace();
		}
		
	}
}
