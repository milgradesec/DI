package salon_habana;

/**
 * BookingData almacena los datos del formulario de nueva reserva.
 */
public class BookingData {

    private String name;
    private String phone;
    private String date;
    private String type;
    private int attendes;
    private String food;
    private int days;
    private boolean rooms;

    public BookingData() {
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public int getAttendes() {
        return attendes;
    }

    public void setAttendes(int attendes) {
        this.attendes = attendes;
    }

    public String getFood() {
        return food;
    }

    public void setFood(String food) {
        this.food = food;
    }

    public int getDays() {
        return days;
    }

    public void setDays(int days) {
        this.days = days;
    }

    public boolean isRooms() {
        return rooms;
    }

    public void setRooms(boolean rooms) {
        this.rooms = rooms;
    }

}