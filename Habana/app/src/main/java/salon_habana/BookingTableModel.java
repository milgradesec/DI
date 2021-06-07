package salon_habana;

import java.util.ArrayList;
import java.util.List;

import javax.swing.table.AbstractTableModel;

/**
 * BookingTableModel implementa un modelo personalizado para visualizar las
 * reservas en una tabla JTable
 */
public class BookingTableModel extends AbstractTableModel {

    public List<BookingData> data = new ArrayList<BookingData>();

    private String[] columnNames = { "Nombre", "Teléfono", "Fecha", "Tipo", "Asistentes", "Comida", "Nº de Jornadas",
            "Reservar Habitaciones" };

    public BookingTableModel() {
    }

    public BookingTableModel(List<BookingData> data) {
        this.data = data;
    }

    @Override
    public int getRowCount() {
        return data.size();
    }

    @Override
    public int getColumnCount() {
        return columnNames.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        Object value = null;
        BookingData bdata = data.get(rowIndex);

        switch (columnIndex) {
        case 0:
            value = bdata.getName();
            break;
        case 1:
            value = bdata.getPhone();
            break;
        case 2:
            value = bdata.getDate();
            break;
        case 3:
            value = bdata.getType();
            break;
        case 4:
            value = bdata.getAttendes();
            break;
        case 5:
            value = bdata.getFood();
            break;
        case 6:
            value = bdata.getDays();
            break;
        case 7:
            value = bdata.isRooms();
            break;
        default:
            break;
        }
        return value;
    }

    public String getColumnName(int col) {
        return columnNames[col];
    }
}
