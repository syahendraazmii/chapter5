using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // Objek yang ingin kita kelilingi
    public float rotationSpeed = 5.0f; // Kecepatan rotasi kamera
    public float distance = 13.0f; // Jarak awal kamera dari objek
    public float height = 7.0f; // Ketinggian kamera dari objek

    private Vector3 lastMousePosition; // Posisi mouse sebelumnya

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition; // Menyimpan posisi mouse saat ini saat tombol mouse ditekan
        }
        else if (Input.GetMouseButton(0))
        {
            // Menghitung perbedaan posisi mouse sebelumnya dan sekarang
            Vector3 delta = Input.mousePosition - lastMousePosition;
            float deltaX = delta.x * rotationSpeed * Time.deltaTime;
            float deltaY = delta.y * rotationSpeed * Time.deltaTime;

            // Memutar kamera berdasarkan pergerakan mouse
            transform.RotateAround(target.position, Vector3.up, deltaX);
            transform.RotateAround(target.position, transform.right, -deltaY);

            lastMousePosition = Input.mousePosition; // Memperbarui posisi mouse terakhir
        }

        // Mengatur posisi kamera agar mengelilingi objek dengan jarak dan ketinggian yang diinginkan
        Vector3 desiredPosition = target.position - transform.forward * distance;
        desiredPosition.y = target.position.y + height;
        transform.position = desiredPosition;
    }
}
