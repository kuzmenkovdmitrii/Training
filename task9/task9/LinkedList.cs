using System;
using System.Runtime.InteropServices;

namespace task9
{
    class LinkedList<T>
        where T : IEquatable<T>
    {
        private Cell<T> head;
        private Cell<T> end;
        private int counter;
        private int length;

        public LinkedList(int length)
        {
            if (length <= 0)
            {
                throw new LinkedListException("You are trying to enter a negative or zero value for the range.");
            }
            this.length = length;
            counter = 0;
        }

        public void Add(T element)
        {
            if (counter >= length)
            {
                throw new LinkedListException("You are trying to add an item out of range.");
            }

            Cell<T> cell = new Cell<T>(element);

            if (head == null)
            {
                head = cell;
                end = cell;
                //cell.Index = counter;
            }
            else
            {
                end.Next = cell;
                end = cell;
                //cell.Index = counter;
            }

            counter++;
        }

        public void Insert(int index, T element)
        {
            if (counter >= length)
            {
                throw new LinkedListException("You are trying to add an item out of range.");
            }

            if (index >= counter + 1 || index < 0)
            {
                throw new LinkedListException("You have entered an index that is outside the list boundaries.");
            }

            if (element == null)
            {
                throw new LinkedListException("You pass a null value.");
            }

            Cell<T> currentCell;
            if (index == 0)
            {
                currentCell = new Cell<T>(element);
                currentCell.Next = head;
                head = currentCell;
                counter++;
            }
            else
            {
                currentCell = head;
                int dynamicIndex = 0;
                while (true)
                {
                    if (dynamicIndex == index - 1)
                    {
                        Cell<T> buffer = currentCell.Next;
                        currentCell.Next = new Cell<T>(element);
                        currentCell.Next.Next = buffer;
                        counter++;
                        break;
                    }

                    currentCell = currentCell.Next;
                    dynamicIndex++;
                }
            }
        }

        public void Remove(T element)
        {
            if (head == null)
            {
                throw new LinkedListException("You cannot delete, the list is empty.");
            }

            if (element == null)
            {
                throw new LinkedListException("You pass a null value.");
            }

            Cell<T> currentCell = head;
            if (head.Value.Equals(element))
            {
                head = head.Next;
                counter--;
            }
            else
            {
                while (true)
                {
                    if (currentCell.Next != null)
                    {
                        if (currentCell.Next.Value.Equals(element))
                        {
                            if (currentCell.Next.Next != null)
                            {
                                currentCell.Next = currentCell.Next.Next;
                                counter--;
                                break;
                            }
                            else
                            {
                                currentCell.Next = null;
                                end = currentCell;
                                counter--;
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }

                    currentCell = currentCell.Next;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (head == null)
            {
                throw new LinkedListException("You cannot delete, the list is empty.");
            }

            if (index >= counter || index < 0)
            {
                throw new LinkedListException("You have entered an index that is outside the list boundaries.");
            }

            if (index == 0)
            {
                head = head.Next;
                counter--;
            }
            else
            {
                Cell<T> currentCell = head;
                int dynamicIndex = 0;
                while (true)
                {
                    if (dynamicIndex == index - 1)
                    {
                        currentCell.Next = currentCell.Next.Next;
                        counter--;
                        break;
                    }

                    currentCell = currentCell.Next;
                    dynamicIndex++;
                }
            }
        }

        public int IndexOf(T element)
        {
            if (element == null)
            {
                throw new LinkedListException("You pass a null value.");
            }

            Cell<T> currentCell = head;
            int dynamicIndex = 0;
            while (true)
            {
                if (dynamicIndex <= length)
                {
                    if (currentCell.Value.Equals(element))
                    {
                        return dynamicIndex;
                    }

                    currentCell = currentCell.Next;
                    dynamicIndex++;
                }
                else
                {
                    return -1;
                }
            }
        }

        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new LinkedListException("You pass a null value.");
            }

            Cell<T> currentCell = head;
            while (true)
            {
                if (currentCell != null)
                {
                    if (currentCell.Value.Equals(element))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }

                currentCell = currentCell.Next;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public override string ToString()
        {
            string outString = "";
            Cell<T> currentCell = head;
            if (currentCell != null)
            {
                while (true)
                {
                    outString += currentCell.Value.ToString() + " ";
                    if (currentCell.Next != null)
                    {
                        currentCell = currentCell.Next;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return outString;
        }
    }
}