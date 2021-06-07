package formulario;

import java.util.ArrayList;
import java.util.List;

import javax.swing.table.AbstractTableModel;

public class DatosFormularioTableModel extends AbstractTableModel {

    private static final long serialVersionUID = 1L;
    public List<DatosFormulario> datos = new ArrayList<>();

    private final String[] nombreColumnas = {"Nombre", "Apellidos", "Domicilio", "Provincia", "Edad", "Sexo",
        "Preferencias", "Comentarios"};

    public DatosFormularioTableModel() {
    }

    public DatosFormularioTableModel(List<DatosFormulario> datos) {
        this.datos = datos;
    }

    @Override
    public String getColumnName(int col) {
        return nombreColumnas[col];
    }

    @Override
    public int getRowCount() {
        return datos.size();
    }

    @Override
    public int getColumnCount() {
        return nombreColumnas.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        Object value = null;
        DatosFormulario formulario = datos.get(rowIndex);

        switch (columnIndex) {
            case 0:
                value = formulario.nombre;
                break;
            case 1:
                value = formulario.apellidos;
                break;
            case 2:
                value = formulario.domicilio;
                break;
            case 3:
                value = formulario.provincia;
                break;
            case 4:
                value = formulario.edad;
                break;
            case 5:
                value = formulario.sexo;
                break;
            case 6:
                value = formulario.preferencias;
                break;
            case 7:
                value = formulario.comentario;
                break;
        }
        return value;
    }
}
