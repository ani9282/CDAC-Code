

class Node
{
	int data;
	Node *next;

public:
	Node();
	Node(int);
	Node(int, Node*);
	~Node();
	Node(Node &);
	void operator=(Node &);
	void operator++(int x);	
	Node* getNext();
	void setNext(Node*);
	int getData();
	void setData(int);
};



