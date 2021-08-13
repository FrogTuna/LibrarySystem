using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class MemberCollection : iMemberCollection
    {


        //fields
        private int countMember;
        private BTreeNode root;
        private List<Member> membersList;



        //construtor
        public MemberCollection()
        {

            countMember = 0;
            root = null;
            membersList = new List<Member>();

        }


        //get the number of members
        public int Number
        {
            get { return countMember; }
        }


        //add member to a MemberCollection
        public void add(Member aMember)
        {

            if (root == null)
            {
                root = new BTreeNode(aMember);
                countMember++;
            }

            else
            {
                Add(aMember, root);
                countMember++;
            }

        }

        // pre: ptr != null
        // post: item is inserted to the binary search tree rooted at ptr
        private void Add(Member member, BTreeNode ptr)
        {
            if (member.CompareTo(ptr.Member) < 0)
            {

                if (ptr.LChild == null)
                {
                    ptr.LChild = new BTreeNode(member);
                    //countMember++;
                }
                else
                {
                    Add(member, ptr.LChild);
                    //countMember++;
                }
            }
            else
            {

                if (ptr.RChild == null)
                {
                    ptr.RChild = new BTreeNode(member);
                    //countMember++;
                }
                else
                {
                    Add(member, ptr.RChild);
                    //countMember++;
                }

            }
        }


        //delete a member from MemberCollection
        public void delete(Member aMember)
        {
            // search for item and its parent
            BTreeNode ptr = root; // search reference
            BTreeNode parent = null; // parent of ptr
            while ((ptr != null) && (aMember.CompareTo(ptr.Member) != 0))
            {
                parent = ptr;
                if (aMember.CompareTo(ptr.Member) < 0) // move to the left child of ptr
                {
                    ptr = ptr.LChild;
                    countMember--;
                }
                else
                {
                    ptr = ptr.RChild;
                    countMember--;
                }
            }

            if (ptr != null) // if the search was successful
            {

                // case 3: item has two children
                if ((ptr.LChild != null) && (ptr.RChild != null))
                {
                    // find the right-most node in left subtree of ptr
                    if (ptr.LChild.RChild == null) // a special case: the right subtree of ptr.LChild is empty
                    {
                        ptr.Member = ptr.LChild.Member;
                        ptr.LChild = ptr.LChild.LChild;
                    }
                    else
                    {
                        BTreeNode p = ptr.LChild;
                        BTreeNode pp = ptr; // parent of p
                        while (p.RChild != null)
                        {
                            pp = p;
                            p = p.RChild;
                        }
                        // copy the item at p to ptr
                        ptr.Member = p.Member;
                        pp.RChild = p.LChild;
                    }
                }
                else // cases 1 & 2: item has no or only one child
                {
                    BTreeNode c;
                    if (ptr.LChild != null)
                    {
                        c = ptr.LChild;
                        countMember--;
                    }
                    else
                    {
                        c = ptr.RChild;
                        countMember--;
                    }

                    // remove node ptr
                    if (ptr == root) //need to change root
                        root = c;
                    else
                    {
                        if (ptr == parent.LChild)
                            parent.LChild = c;
                        else
                            parent.RChild = c;
                    }
                }

            }

        }

        //verify if amember in the list
        public bool search(Member aMember)
        {
            return Search(aMember, root);
        }

        
        private bool Search(Member member, BTreeNode r)
        {
            if (r != null)
            {
                if (member.CompareTo(r.Member) == 0)
                    return true;
                else
                    if (member.CompareTo(r.Member) < 0)
                    return Search(member, r.LChild);
                else
                    return Search(member, r.RChild);
            }
            else
                return false;
        }


        //if member is in the list return that number
        public Member searchMember(Member aMember)
        {
            return SearchMember(aMember, root);
        }


        private Member SearchMember(Member member, BTreeNode r)
        {
            if (r != null)
            {
                if (member.CompareTo(r.Member) == 0)
                    return member;
                else
                    if (member.CompareTo(r.Member) < 0)
                    return SearchMember(member, r.LChild);
                else
                    return SearchMember(member, r.RChild);
            }
            else
                return null;
        }


        //indorder membercollection
        private void InOrderTraverse()
        {

            InOrderTraverse(root);

        }

        private void InOrderTraverse(BTreeNode root)
        {


            if (root != null)
            {
                    InOrderTraverse(root.LChild);
                    membersList.Add(root.Member);
                    InOrderTraverse(root.RChild);
            }          

        }


        //return a inorder collection array
        public Member[] toArray()
        {

            InOrderTraverse();
            
            Member[] iArray = membersList.ToArray();

            //clear memberList 
            membersList.Clear();

            return iArray;
        }
    }
}
