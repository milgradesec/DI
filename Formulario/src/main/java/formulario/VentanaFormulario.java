package formulario;

import java.util.List;
import javax.swing.*;

public class VentanaFormulario extends javax.swing.JDialog {

        private static final long serialVersionUID = 1L;
        private List<DatosFormulario> db;

        /**
         * Creates new form formulario
         */
        public VentanaFormulario(java.awt.Frame parent, boolean modal, List<DatosFormulario> datos) {
                super(parent, modal);
                initComponents();
                this.db = datos;
        }

        /**
         * This method is called from within the constructor to initialize the form.
         * WARNING: Do NOT modify this code. The content of this method is always
         * regenerated by the Form Editor.
         */
        @SuppressWarnings("unchecked")
        // <editor-fold defaultstate="collapsed" desc="Generated
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        nombre = new javax.swing.JLabel();
        apellidos = new javax.swing.JLabel();
        domicilio = new javax.swing.JLabel();
        provincia = new javax.swing.JLabel();
        edad = new javax.swing.JLabel();
        sexo = new javax.swing.JLabel();
        btnEnviar = new javax.swing.JButton();
        btnBorrar = new javax.swing.JButton();
        campoNombre = new javax.swing.JTextField();
        campoApellidos = new javax.swing.JTextField();
        campoDomicilio = new javax.swing.JTextField();
        campoProvincia = new javax.swing.JComboBox<>();
        campoEdad = new javax.swing.JSpinner();
        opcionHombre = new javax.swing.JRadioButton();
        opcionMujer = new javax.swing.JRadioButton();
        preferencias = new javax.swing.JLabel();
        campoMySQL = new javax.swing.JCheckBox();
        campoJava = new javax.swing.JCheckBox();
        campoPHP = new javax.swing.JCheckBox();
        campoWebServices = new javax.swing.JCheckBox();
        campoXML = new javax.swing.JCheckBox();
        campoPython = new javax.swing.JCheckBox();
        campoCSS = new javax.swing.JCheckBox();
        campoASP = new javax.swing.JCheckBox();
        campoWebMovil = new javax.swing.JCheckBox();
        campoQtDesigner = new javax.swing.JCheckBox();
        jLabel8 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        campoComentarios = new javax.swing.JTextArea();

        buttonGroup1.add(opcionHombre);
        buttonGroup1.add(opcionMujer);

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Formulario");

        nombre.setText("Nombre:");

        apellidos.setText("Apellidos:");

        domicilio.setText("Domicilio:");

        provincia.setText("Provincia:");

        edad.setText("Edad:");

        sexo.setText("Sexo:");

        btnEnviar.setText("Enviar");
        btnEnviar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEnviarActionPerformed(evt);
            }
        });

        btnBorrar.setText("Borrar");
        btnBorrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBorrarActionPerformed(evt);
            }
        });

        campoProvincia.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Huesca", "Zaragoza", "Teruel" }));
        campoProvincia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                campoProvinciaActionPerformed(evt);
            }
        });

        campoEdad.setModel(new javax.swing.SpinnerNumberModel(18, 18, 30, 1));

        opcionHombre.setText("Hombre");

        opcionMujer.setText("Mujer");

        preferencias.setText("Preferencias:");

        campoMySQL.setText("MySQL");

        campoJava.setText("Java");

        campoPHP.setText("PHP");

        campoWebServices.setText("Web Services");

        campoXML.setText("XML");

        campoPython.setText("Python");

        campoCSS.setText("CSS");

        campoASP.setText("ASP NET");
        campoASP.setEnabled(false);

        campoWebMovil.setText("Web M�vil");

        campoQtDesigner.setText("QT Designer");
        campoQtDesigner.setEnabled(false);

        jLabel8.setText("Comentarios:");

        campoComentarios.setColumns(20);
        campoComentarios.setRows(5);
        jScrollPane1.setViewportView(campoComentarios);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addGap(14, 14, 14)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(campoMySQL, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(campoJava, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(campoXML, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(campoPython, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addComponent(campoWebServices)
                                        .addGap(27, 27, 27))
                                    .addComponent(campoPHP, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(campoCSS, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(campoWebMovil, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(0, 0, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(apellidos)
                                            .addComponent(provincia)
                                            .addComponent(domicilio)
                                            .addComponent(nombre, javax.swing.GroupLayout.PREFERRED_SIZE, 58, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addGap(28, 28, 28)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addComponent(campoApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, 189, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(campoNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 189, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(campoDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, 189, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(campoProvincia, javax.swing.GroupLayout.PREFERRED_SIZE, 189, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(edad, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                                                .addGap(31, 31, 31))
                                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                                    .addComponent(sexo, javax.swing.GroupLayout.Alignment.LEADING)
                                                    .addComponent(preferencias, javax.swing.GroupLayout.Alignment.LEADING))
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)))
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(opcionHombre)
                                                .addGap(18, 18, 18)
                                                .addComponent(opcionMujer, javax.swing.GroupLayout.PREFERRED_SIZE, 96, javax.swing.GroupLayout.PREFERRED_SIZE))
                                            .addComponent(campoEdad, javax.swing.GroupLayout.PREFERRED_SIZE, 189, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 240, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(27, 27, 27)))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 20, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(campoASP, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(campoQtDesigner, javax.swing.GroupLayout.DEFAULT_SIZE, 107, Short.MAX_VALUE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(btnBorrar)
                                .addGap(26, 26, 26)
                                .addComponent(btnEnviar)))
                        .addContainerGap(54, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel8)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(campoNombre, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(nombre))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(campoApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(apellidos))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(campoDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(domicilio))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(campoProvincia, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(provincia))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(edad)
                    .addComponent(campoEdad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(opcionHombre)
                    .addComponent(opcionMujer)
                    .addComponent(sexo))
                .addGap(18, 18, 18)
                .addComponent(preferencias)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(campoMySQL)
                    .addComponent(campoWebServices)
                    .addComponent(campoASP))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(campoJava)
                    .addComponent(campoPHP)
                    .addComponent(campoQtDesigner))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(campoXML)
                    .addComponent(campoCSS))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(campoPython)
                    .addComponent(campoWebMovil))
                .addGap(26, 26, 26)
                .addComponent(jLabel8)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 44, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnEnviar)
                            .addComponent(btnBorrar)))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addGap(23, 23, 23))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

        private void btnBorrarActionPerformed(java.awt.event.ActionEvent evt) {// GEN-FIRST:event_btnBorrarActionPerformed
                borrarCampos();
        }// GEN-LAST:event_btnBorrarActionPerformed

        private void campoProvinciaActionPerformed(java.awt.event.ActionEvent evt) {// GEN-FIRST:event_campoProvinciaActionPerformed
                if (campoProvincia.getSelectedIndex() == 1) {
                        campoASP.setEnabled(true);
                        campoQtDesigner.setEnabled(true);
                } else {
                        campoASP.setEnabled(false);
                        campoQtDesigner.setEnabled(false);
                        campoASP.setSelected(false);
                        campoQtDesigner.setSelected(false);
                }
        }// GEN-LAST:event_campoProvinciaActionPerformed

        private void btnEnviarActionPerformed(java.awt.event.ActionEvent evt) {// GEN-FIRST:event_btnEnviarActionPerformed
                if (campoNombre.getText().length() == 0 || campoApellidos.getText().length() == 0
                                || campoDomicilio.getText().length() == 0) {
                        JOptionPane.showMessageDialog(this, "Faltan campos obligatorios", "Alerta",
                                        JOptionPane.WARNING_MESSAGE);
                } else {
                        DatosFormulario datos = new DatosFormulario();
                        datos.setNombre(campoNombre.getText());
                        datos.setApellidos(campoApellidos.getText());
                        datos.setDomicilio(campoDomicilio.getText());
                        datos.setProvincia(campoProvincia.getSelectedItem().toString());
                        datos.setEdad((int) campoEdad.getValue());
                        if (opcionHombre.isSelected()) {
                                datos.setSexo("Hombre");
                        } else {
                                datos.setSexo("Mujer");
                        }
                        datos.setComentario(campoComentarios.getText());

                        if (campoMySQL.isSelected()) {
                                datos.preferencias += "MySQL, ";
                        }
                        if (campoJava.isSelected()) {
                                datos.preferencias += "Java, ";
                        }
                        if (campoXML.isSelected()) {
                                datos.preferencias += "XML, ";
                        }
                        if (campoPython.isSelected()) {
                                datos.preferencias += "Python, ";
                        }
                        if (campoWebServices.isSelected()) {
                                datos.preferencias += "Web Services, ";
                        }
                        if (campoPHP.isSelected()) {
                                datos.preferencias += "PHP, ";
                        }
                        if (campoCSS.isSelected()) {
                                datos.preferencias += "CSS, ";
                        }
                        if (campoWebMovil.isSelected()) {
                                datos.preferencias += "Web Móvil, ";
                        }
                        if (campoASP.isSelected()) {
                                datos.preferencias += "ASP, ";
                        }
                        if (campoQtDesigner.isSelected()) {
                                datos.preferencias += "Qt Designer, ";
                        }
                        this.db.add(datos);

                        JOptionPane.showMessageDialog(this, "Datos enviados correctamente", "Información",
                                        JOptionPane.INFORMATION_MESSAGE);
                }
        }// GEN-LAST:event_btnEnviarActionPerformed

        private void borrarCampos() {
                campoNombre.setText("");
                campoApellidos.setText("");
                campoDomicilio.setText("");
                campoComentarios.setText("");
                campoProvincia.setSelectedIndex(0);
                campoEdad.setValue(18);
                buttonGroup1.clearSelection();
        }

        /**
         * @param args the command line arguments
         */
        public static void main(String args[]) {
                /* Set the Nimbus look and feel */
                // <editor-fold defaultstate="collapsed" desc=" Look and feel setting code
                // (optional) ">
                /*
                 * If Nimbus (introduced in Java SE 6) is not available, stay with the default
                 * look and feel. For details see
                 * http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
                 */
                try {
                        for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager
                                        .getInstalledLookAndFeels()) {
                                if ("Nimbus".equals(info.getName())) {
                                        javax.swing.UIManager.setLookAndFeel(info.getClassName());
                                        break;
                                }
                        }
                } catch (ClassNotFoundException ex) {
                        java.util.logging.Logger.getLogger(VentanaFormulario.class.getName())
                                        .log(java.util.logging.Level.SEVERE, null, ex);
                } catch (InstantiationException ex) {
                        java.util.logging.Logger.getLogger(VentanaFormulario.class.getName())
                                        .log(java.util.logging.Level.SEVERE, null, ex);
                } catch (IllegalAccessException ex) {
                        java.util.logging.Logger.getLogger(VentanaFormulario.class.getName())
                                        .log(java.util.logging.Level.SEVERE, null, ex);
                } catch (javax.swing.UnsupportedLookAndFeelException ex) {
                        java.util.logging.Logger.getLogger(VentanaFormulario.class.getName())
                                        .log(java.util.logging.Level.SEVERE, null, ex);
                }
                // </editor-fold>
                // </editor-fold>
                // </editor-fold>
                // </editor-fold>

                /* Create and display the dialog */
                java.awt.EventQueue.invokeLater(new Runnable() {
                        public void run() {
                                VentanaFormulario dialog = new VentanaFormulario(new javax.swing.JFrame(), true, null);
                                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                                        @Override
                                        public void windowClosing(java.awt.event.WindowEvent e) {
                                                System.exit(0);
                                        }
                                });
                                dialog.setVisible(true);
                        }
                });
        }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel apellidos;
    private javax.swing.JButton btnBorrar;
    private javax.swing.JButton btnEnviar;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JCheckBox campoASP;
    private javax.swing.JTextField campoApellidos;
    private javax.swing.JCheckBox campoCSS;
    private javax.swing.JTextArea campoComentarios;
    private javax.swing.JTextField campoDomicilio;
    private javax.swing.JSpinner campoEdad;
    private javax.swing.JCheckBox campoJava;
    private javax.swing.JCheckBox campoMySQL;
    private javax.swing.JTextField campoNombre;
    private javax.swing.JCheckBox campoPHP;
    private javax.swing.JComboBox<String> campoProvincia;
    private javax.swing.JCheckBox campoPython;
    private javax.swing.JCheckBox campoQtDesigner;
    private javax.swing.JCheckBox campoWebMovil;
    private javax.swing.JCheckBox campoWebServices;
    private javax.swing.JCheckBox campoXML;
    private javax.swing.JLabel domicilio;
    private javax.swing.JLabel edad;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel nombre;
    private javax.swing.JRadioButton opcionHombre;
    private javax.swing.JRadioButton opcionMujer;
    private javax.swing.JLabel preferencias;
    private javax.swing.JLabel provincia;
    private javax.swing.JLabel sexo;
    // End of variables declaration//GEN-END:variables
}
