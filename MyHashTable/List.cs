﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class List
    {

        private class Node
		{
            public Node Next { get; set; }//указатель на следующий элемент
            public int data { get; set; }//ключ

        };

		Node Head,Tail;//голова и хвост списка
        public List()
		{
			Head = Tail=null;
		}

        //Добавить элемент в список
        //Формальные параметры: ключ
        //Входные данные: список
        //Выходные данные: список
        public void add(int x)
		{
			Node temp = new Node();     //Добавление нового элемента в список            
			temp.Next = Head;
			temp.data = x;
			if (Head != null)
			{
				Tail.Next = temp;
				Tail = temp;
			}
			else Head = Tail = temp;

		}

        //Счетчик
        //Формальные параметры:---
        //Входные данные: список
        //Выходные данные: список
        public int Count()
        {
            int size = 1;//счётчик 
            Node temp = Head; //резервный указатель на первый элемент
            if (Head == null) size = 0;
            else if (Head == Tail) size = 1;
            else while (temp != Tail)
                {
                    temp = temp.Next;
                    size++;
                }
            return size;
        }

        //Проверяет, содержится ли элемент в списке
        //Формальные параметры:ключ
        //Входные данные: список
        //Выходные данные: список
        public bool Contains(int x)
        {
            Node temp = Head; //резервный указатель на первый элемент
            for (int i = 0; i < Count(); i++)
            {
                if (temp.data==x)
                {
                    return true;
                }
                temp = temp.Next;
            }
            
            return false;
        }


        //
        //Формальные параметры:---
        //Входные данные: список
        //Выходные данные: список
        public void Show()
        {
            Node tempHead = Head;
            int temp = Count();          
            if (Count() == 0) Console.WriteLine("no items in the list"); 
            else
                while (temp != 0)
                {
                    Console.WriteLine(tempHead.data + " "); 
                    tempHead = tempHead.Next;
                    temp--;
                }
        }


        //Удалить элемент из списка
        //Формальные параметры:ключ
        //Входные данные: список
        //Выходные данные: список
        public void delete(int x)
        {
            
            Node Del = Head,term=null;  //Вспомогательный указатель для удаления элемента

            while (Del.data!=x)
            {
                term = Del;
                Del = Del.Next;
            }
                
            switch (Count())
            {     
                case 1:
                    Head = Tail = null;
                    break;
                case 2:
                    if (Head.data == x) Head = Tail; else Tail = Head;
                    break;
                default:
                    if(Del == Tail)
                    {
                        Tail = term;
                        break;
                    }
                    if(Del == Head)
                    {
                        Head = Head.Next;
                        break;
                    }
                    term.Next = Del.Next;
                    break; 
            }




        }


    }
}
