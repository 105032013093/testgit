using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
namespace FilmsSelect
{ 
    class PathHelper
    {
        public static String defaultDirectory = "Images"; //ͼƬĬ�ϴ洢Ŀ¼
        public static String currentDirectory = Directory.GetCurrentDirectory(); //��ǰ����Ŀ¼
        public static String relPathDirectory = "";//���·��������Ԫ���ǵõ�
        public static String relPath = "";//���ݿ��ж��������·��
    }
}
