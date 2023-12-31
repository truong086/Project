/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.ui;

import com.btljava.controller.BenhNhanController;
import com.btljava.controller.GiuongNguController;
import com.btljava.controller.LoaiGiuongController;
import com.btljava.dao.impl.giuongnguDao;
import com.btljava.helper.DataValidor;
import com.btljava.helper.MessageDialog;
import com.btljava.helper.ShereData;
import com.btljava.model.benhnhan;
import com.btljava.model.giuongngu;
import com.btljava.model.loaigiuong;
import java.awt.Color;
import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author ASUS
 */
public class giuongnguss extends javax.swing.JDialog {
    private fromMain mains;
    private DefaultTableModel model;
    int ids = 0;
    
    private GiuongNguController dao = new GiuongNguController();
    private BenhNhanController daos = new BenhNhanController();
    private LoaiGiuongController daoss = new LoaiGiuongController();
    
    /**
     * Creates new form giuongnguss
     */
    public giuongnguss(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        
        
    }
    
    private void phanquyen(){
        String phanquyen = String.valueOf(ShereData.dangnhap.getPhanquyen());
        if(phanquyen.equals("2")){
            deletes.hide();
        }
        if(phanquyen.equals("3")){
            add.hide();
            edits.hide();
            deletes.hide();
            
        }
    }
    
    private void initTable(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Giường id", "Bệnh nhân id", "Ngày nằm", "Ngày ra"
        });
        
        tblTable.setModel(model);
    }
    
    private void loadDataTable(){
        try{
//            giuongnguDao dao = new giuongnguDao();
            List<giuongngu> list = dao.findAll();
            model.setRowCount(0);
            for(giuongngu gn : list){
                model.addRow(new Object[] {
                    gn.getId(), gn.getGiuong_id(), gn.getBenhnhan_id(), gn.getThoigiannam(), gn.getThoigianra()
                });
            }
            
            model.fireTableDataChanged();
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void timkiem(){
        try{
//            giuongnguDao dao = new giuongnguDao();
            List<giuongngu> list = dao.timkiem(timkiems.getText());
            model.setRowCount(0);
            for(giuongngu gn : list){
                model.addRow(new Object[] {
                    gn.getId(), gn.getGiuong_id(), gn.getBenhnhan_id(), gn.getThoigiannam(), gn.getThoigianra()
                });
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        timkiems = new javax.swing.JTextField();
        add = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        edits = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        deletes = new javax.swing.JButton();
        jLabel3 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblTable = new javax.swing.JTable();
        jLabel4 = new javax.swing.JLabel();
        magiuongngus = new javax.swing.JTextField();
        mabenhnhans = new javax.swing.JTextField();
        thoigiannams = new javax.swing.JTextField();
        thoigianras = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        quyen = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        loaigiuongs = new javax.swing.JTable();
        timkiemss = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        benhnhanss = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });

        timkiems.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                timkiemsKeyReleased(evt);
            }
        });

        add.setText("Add");
        add.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                addActionPerformed(evt);
            }
        });

        jLabel1.setText("Mã giường ngủ");

        edits.setText("Edit");
        edits.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                editsActionPerformed(evt);
            }
        });

        jLabel2.setText("Mã bệnh nhân");

        deletes.setText("Delete");
        deletes.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                deletesActionPerformed(evt);
            }
        });

        jLabel3.setText("Thời gian nằm");

        tblTable.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        tblTable.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblTableMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tblTable);

        jLabel4.setText("Thời gian ra");

        jLabel5.setText("Tìm kiếm");

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 48)); // NOI18N
        jLabel7.setText("Giường ngủ");

        quyen.setText("jButton1");

        loaigiuongs.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane2.setViewportView(loaigiuongs);

        timkiemss.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                timkiemssKeyReleased(evt);
            }
        });

        jLabel6.setText("Tìm kiếm");

        benhnhanss.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane3.setViewportView(benhnhanss);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 531, Short.MAX_VALUE)
                    .addComponent(jScrollPane2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 34, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel7)
                        .addGap(477, 477, 477)
                        .addComponent(quyen))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING)
                        .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(jLabel1)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(add, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel2)))
                            .addGap(18, 18, 18)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(magiuongngus, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(mabenhnhans, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(edits, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 116, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGap(18, 18, 18)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(layout.createSequentialGroup()
                                    .addGap(59, 59, 59)
                                    .addComponent(jLabel5)
                                    .addGap(18, 18, 18)
                                    .addComponent(timkiems, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(jLabel3)
                                        .addComponent(jLabel4))
                                    .addGap(18, 18, 18)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(thoigianras, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(thoigiannams, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                    .addComponent(deletes, javax.swing.GroupLayout.PREFERRED_SIZE, 106, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(170, 170, 170))))))
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGap(101, 101, 101)
                .addComponent(jLabel6)
                .addGap(18, 18, 18)
                .addComponent(timkiemss, javax.swing.GroupLayout.PREFERRED_SIZE, 264, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(62, 62, 62)
                        .addComponent(quyen))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel7)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(timkiemss, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(32, 32, 32)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(jLabel3)
                                    .addComponent(thoigiannams, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(55, 55, 55)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(jLabel4)
                                    .addComponent(thoigianras, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(jLabel1)
                                    .addComponent(magiuongngus, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(55, 55, 55)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(jLabel2)
                                    .addComponent(mabenhnhans, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                        .addGap(45, 45, 45)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(timkiems, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(85, 85, 85)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(add, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(edits, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(deletes, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)))
                .addGap(33, 33, 33)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 284, Short.MAX_VALUE)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void timkiemsKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_timkiemsKeyReleased
        // TODO add your handling code here:

        String value = timkiems.getText();
        if(value.equals("")){
            loadDataTable();
        }else{
            timkiem();
        }
    }//GEN-LAST:event_timkiemsKeyReleased

    private void addActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_addActionPerformed
        // TODO add your handling code here:
        int benhnhan = 0;
        int giuongngu = 0;

        StringBuilder sb = new StringBuilder();

        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");
        DataValidor.kiemtra(mabenhnhans, sb, "Mã bệnh nhân không được để trống");
        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");
        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");

        if(sb.length() > 0){
            MessageDialog.showMessageError(mains, sb.toString(), "Lỗi");
            return;
        }

        if(magiuongngus.getText().chars().allMatch(Character :: isDigit) && mabenhnhans.getText().chars().allMatch(Character :: isDigit)){
            giuongngu = Integer.parseInt(magiuongngus.getText());
            benhnhan = Integer.parseInt(mabenhnhans.getText());
        }else{
            MessageDialog.showMessageError(mains, "Mã bệnh nhân và mã giường nằm phải là số", "Lỗi");
            return;
        }

        try{
            giuongngu gn = new giuongngu();
            gn.setGiuong_id(giuongngu);
            gn.setBenhnhan_id(benhnhan);
            gn.setThoigiannam(thoigiannams.getText());
            gn.setThoigianra(thoigianras.getText());
//            giuongnguDao dao = new giuongnguDao();
            if(dao.insert(gn)){
                MessageDialog.showMessageDialog(mains, "Thêm dữ liệu thành công", "Lỗi");
                loadDataTable();
            }else{
                MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "Lỗi");
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_addActionPerformed

    private void editsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_editsActionPerformed
        // TODO add your handling code here:

        int benhnhan = 0;
        int giuongngu = 0;

        StringBuilder sb = new StringBuilder();

        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");
        DataValidor.kiemtra(mabenhnhans, sb, "Mã bệnh nhân không được để trống");
        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");
        DataValidor.kiemtra(magiuongngus, sb, "Mã giường ngủ không được để trống");

        if(sb.length() > 0){
            MessageDialog.showMessageError(mains, sb.toString(), "Lỗi");
            return;
        }

        if(magiuongngus.getText().chars().allMatch(Character :: isDigit) && mabenhnhans.getText().chars().allMatch(Character :: isDigit)){
            giuongngu = Integer.parseInt(magiuongngus.getText());
            benhnhan = Integer.parseInt(mabenhnhans.getText());
        }else{
            MessageDialog.showMessageError(mains, "Mã bệnh nhân và mã giường nằm phải là số", "Lỗi");
            return;
        }

        try{
            giuongngu gn = new giuongngu();
            gn.setId(ids);
            gn.setBenhnhan_id(benhnhan);
            gn.setGiuong_id(giuongngu);
            gn.setThoigiannam(thoigiannams.getText());
            gn.setThoigianra(thoigianras.getText());
//            giuongnguDao dao = new giuongnguDao();
            if(dao.update(gn)){
                MessageDialog.showMessageDialog(mains, "Update liệu thành công", "Lỗi");
                loadDataTable();
            }else{
                MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "Lỗi");
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_editsActionPerformed

    private void deletesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_deletesActionPerformed
        // TODO add your handling code here:

        if(MessageDialog.showConfirmDialog(mains, "Bạn chắc chắn muốn xóa bản ghi không", "Lỗi") == JOptionPane.NO_OPTION){
            return;
        }

        try{
//            giuongnguDao dao = new giuongnguDao();
            String id = String.valueOf(ids);
            if(dao.delete(id)){
                MessageDialog.showMessageDialog(mains, "Xóa bản ghi thành công", "Thông báo");
                loadDataTable();
            }else{
                MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "Lỗi");
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_deletesActionPerformed

    private void tblTableMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblTableMouseClicked
        // TODO add your handling code here:
        try{
            int row = tblTable.getSelectedRow();
            if(row >= 0){
                ids = (int) tblTable.getValueAt(row, 0);
//                giuongnguDao dao = new giuongnguDao();
                giuongngu gn = dao.findbyid(ids);
                String giuongnguid = String.valueOf(gn.getGiuong_id());
                String benhnhanid = String.valueOf(gn.getBenhnhan_id());
                if(gn != null){
                    magiuongngus.setText(giuongnguid);
                    mabenhnhans.setText(benhnhanid);
                    thoigiannams.setText(gn.getThoigiannam());
                    thoigianras.setText(gn.getThoigianra());
                }
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_tblTableMouseClicked

    private void checkLogin(){
        int phanquyen = ShereData.dangnhapss.getPhanquyen();
        if(phanquyen == 1){
            quyen.setForeground(Color.red);
            quyen.setText("Admin");
        }
        if(phanquyen == 2){
            quyen.setForeground(Color.red);
            quyen.setText("Quản lý");
        }
        if(phanquyen == 3){
            quyen.setForeground(Color.red);
            quyen.setText("Bệnh nhân");
        }
    }
    
    private void initbenhnhan(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Họ tên", "Địa chỉ", "Ngày sinh"
        });
        
        benhnhanss.setModel(model);
    }
    
    private void benhnhan(){
        try{
            List<benhnhan> list = daos.findAll();
            model.setRowCount(0);
            if(list != null){
                for(benhnhan bn : list){
                    model.addRow(new Object[] {
                        bn.getMabenhnhan(), bn.getHoten(), bn.getDiachi(), bn.getNgaysinh()
                    });
                }
            }
            model.fireTableDataChanged();
        }catch(Exception e){
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
    }
    
    private void initloaigiuong(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Tên giường", "Số lượng", "Ngày tạo"
        });
        loaigiuongs.setModel(model);
    }
    
    private void loadLoaiGiuong(){
        try{
            List<loaigiuong> list = daoss.findAll();
            model.setRowCount(0);
            if(list != null){
                for(loaigiuong lg : list){
                    model.addRow(new Object[] {
                        lg.getId(), lg.getTengiuong(), lg.getSoluong(), lg.getNgaytao()
                    });
                }
            }
            
            model.fireTableDataChanged();
        }catch(Exception e){
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
    }
    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        // TODO add your handling code here:
        phanquyen();
        initTable();
        loadDataTable();
        checkLogin();
        initbenhnhan();
        benhnhan();
        
        initloaigiuong();
        loadLoaiGiuong();
    }//GEN-LAST:event_formWindowOpened

    private void timkiembenhnhan(String s){
        try{
            List<benhnhan> list = daos.timkiem(s);
            model.setRowCount(0);
            if(list != null){
                for(benhnhan bn : list){
                    model.addRow(new Object[] {
                        bn.getMabenhnhan(), bn.getHoten(), bn.getDiachi(), bn.getNgaysinh()
                    });
                }
            }
            
            model.fireTableDataChanged();
            benhnhanss.setModel(model);
        }catch(Exception e){
            MessageDialog.showMessageError(this, e.getMessage(), "Lỗi");
        }
    }
    private void timkiemssKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_timkiemssKeyReleased
        // TODO add your handling code here:
        String value = timkiemss.getText();
        if(value.equals("")){
            loadDataTable();
        }else{
            timkiembenhnhan(value);
        }
    }//GEN-LAST:event_timkiemssKeyReleased

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(giuongnguss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(giuongnguss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(giuongnguss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(giuongnguss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                giuongnguss dialog = new giuongnguss(new javax.swing.JFrame(), true);
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
    private javax.swing.JButton add;
    private javax.swing.JTable benhnhanss;
    private javax.swing.JButton deletes;
    private javax.swing.JButton edits;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTable loaigiuongs;
    private javax.swing.JTextField mabenhnhans;
    private javax.swing.JTextField magiuongngus;
    private javax.swing.JButton quyen;
    private javax.swing.JTable tblTable;
    private javax.swing.JTextField thoigiannams;
    private javax.swing.JTextField thoigianras;
    private javax.swing.JTextField timkiems;
    private javax.swing.JTextField timkiemss;
    // End of variables declaration//GEN-END:variables
}
