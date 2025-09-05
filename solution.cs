public class DynamicArray {
    int[] array;
    int capacity;
    int size;
    public DynamicArray(int  cap ) {
        size = 0;
        capacity = cap;
        array = new int[capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }   

    public void PushBack(int n) {
        if(size == capacity){
            Resize();
        }
        array[size] = n;
        size++;
    }

    public int PopBack() {
        return array[--size];
    }

    private void Resize() {
        capacity = capacity * 2;
        int[] newArray = new int[capacity];
        for(int i = 0; i < size; i++){
            newArray[i] = array[i];
        }
        array = newArray;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
