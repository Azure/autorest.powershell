export class TrieNode {
  value: string;
  private children: Map<string, TrieNode>;
  isEnd: boolean;
  constructor(value: string) {
    this.value = value;
    this.children = new Map<string, TrieNode>();
    this.isEnd = false;
  }

  addChild(child: TrieNode): void
  addChild(child: string): void
  addChild(child: unknown): void {
    if (typeof child === 'string' && !this.children.has(child)) {
      this.children.set(child, new TrieNode(child));
    } else if (child instanceof TrieNode && !this.children.has(child.value)) {
      this.children.set(child.value, child);
    } else {
      throw new Error('invalid trie node or trie node value.');
    }
  }

  hasChild(child: TrieNode): boolean
  hasChild(child: string): boolean
  hasChild(child: unknown): boolean {
    let value: string;
    if (typeof child === 'string') {
      value = child;
    } else if (child instanceof TrieNode) {
      value = child.value;
    } else {
      throw new Error('invalid trie node or trie node value.');
    }
    return this.children.has(value);
  }

  getChild(key: string): TrieNode | undefined {
    return this.children.get(key);
  }
}