

class Node
{
	Node* prev;
	int data;
	Node* next;

public:
	Node();
	Node(int);
	Node(int, Node*);
	Node(Node*, int);
	Node(Node*, int, Node*);
	~Node();
	Node(Node &);
	void operator=(Node &);
	void operator++(int x);
	Node* getNext();
	void setPrev(Node*);
	Node* getPrev();
	void setNext(Node*);
	int getData();
	void setData(int);
};



