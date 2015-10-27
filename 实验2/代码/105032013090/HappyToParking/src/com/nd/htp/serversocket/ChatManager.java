package com.nd.htp.serversocket;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Vector;

public class ChatManager {

	
	private Socket socket;
	private BufferedReader	reader;
	private PrintWriter	writer;
	
	//单例模式
         private ChatManager(){}
         private static final ChatManager chatManager=new ChatManager();
         public static ChatManager getCM(){
        	 return chatManager;
         }
         
         
        
         
         public void connect(String ip) {
        	new Thread(){

				@Override
				public void run() {
					// TODO Auto-generated method stub
					try {
						socket=new Socket(ip, 12345);
						writer = new PrintWriter(
								new OutputStreamWriter(
										socket.getOutputStream()));
						
						reader = new BufferedReader(
								new InputStreamReader(
										socket.getInputStream()));
					String line;
					while ((line = reader.readLine()) != null) {
					//	window.appendText("收到："+line);
					}
					writer.close();
					reader.close();
					writer = null;
					reader = null;
					} catch (UnknownHostException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					super.run();
				}
        		
        		
        	}.start();    		
     	}
         
         public void send(String out) {
        	 if (writer != null) {
     			writer.write(out+"\n");//只有加上一个“结束标记”（“\n”）才能刷新
     			writer.flush();
     		}else {
     		
     		}     		
     	}
}
