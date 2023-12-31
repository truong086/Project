/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.ui;

import com.btljava.controller.ChucVuController;
import com.btljava.dao.impl.chucvuDao;
import com.btljava.helper.DataValidor;
import com.btljava.helper.MessageDialog;
import com.btljava.helper.ShereData;
import com.btljava.model.chucvu;
import java.awt.Color;
import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author ASUS
 */
public class chucvuss extends javax.swing.JDialog {
    private fromMain mains;
    private DefaultTableModel model;
    int ids = 0;
    
    private ChucVuController dao = new ChucVuController();
    
    /**
     * Creates new form chucvuss
     */
    public chucvuss(java.awt.Frame parent, boolean modal) {
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
        model.setColumnIdentifiers(new String[] {"ID", "Mã chức vụ", "Tên chức vụ", "Ngày tạo", "Mã lương", "Khen thưởng"});
        tbltable.setModel(model);
    }
    
    private void loadDataTable(){
        try{
//            chucvuDao dao = new chucvuDao();
            List<chucvu> list = dao.findAll();
            model.setRowCount(0);
            for(chucvu cv : list){
                model.addRow(new Object[] {
                    cv.getId(), cv.getMachucvu(), cv.getTenchucvu(), cv.getNgaytao(), cv.getTienluong_id(), cv.getKhenthuong()
                });
            }
            
            model.fireTableDataChanged();
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

        filler1 = new javax.swing.Box.Filler(new java.awt.Dimension(0, 0), new java.awt.Dimension(0, 0), new java.awt.Dimension(32767, 32767));
        filler2 = new javax.swing.Box.Filler(new java.awt.Dimension(0, 0), new java.awt.Dimension(0, 0), new java.awt.Dimension(32767, 32767));
        edits = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        deletes = new javax.swing.JButton();
        jLabel3 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tbltable = new javax.swing.JTable();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        timkiems = new javax.swing.JTextField();
        machucvus = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        ngaytaos = new javax.swing.JTextField();
        tenchucvus = new javax.swing.JTextField();
        maluongs = new javax.swing.JTextField();
        khenthuongs = new javax.swing.JTextField();
        add = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        quyen = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });

        edits.setText("Edit");
        edits.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                editsActionPerformed(evt);
            }
        });

        jLabel2.setText("Tên chức vụ");

        deletes.setText("Delete");
        deletes.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                deletesActionPerformed(evt);
            }
        });

        jLabel3.setText("Ngày tạo");

        tbltable.setModel(new javax.swing.table.DefaultTableModel(
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
        tbltable.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tbltableMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tbltable);

        jLabel4.setText("Mã lương");

        jLabel5.setText("Khen thưởng");

        timkiems.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                timkiemsKeyReleased(evt);
            }
        });

        jLabel6.setText("Tìm kiếm");

        add.setText("Add");
        add.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                addActionPerformed(evt);
            }
        });

        jLabel1.setText("Mã chức vụ");

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 48)); // NOI18N
        jLabel7.setText("Chức vụ");

        quyen.setText("jButton1");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(20, 20, 20)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 285, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel6)
                                    .addGap(18, 18, 18)
                                    .addComponent(timkiems, javax.swing.GroupLayout.PREFERRED_SIZE, 241, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(18, 18, 18))
                                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 615, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel4)
                                        .addGap(35, 35, 35)
                                        .addComponent(maluongs))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel3)
                                        .addGap(38, 38, 38)
                                        .addComponent(ngaytaos))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel5)
                                        .addGap(18, 18, 18)
                                        .addComponent(khenthuongs))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel2)
                                        .addGap(18, 18, 18)
                                        .addComponent(tenchucvus))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel1)
                                        .addGap(18, 18, 18)
                                        .addComponent(machucvus, javax.swing.GroupLayout.PREFERRED_SIZE, 270, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGap(87, 87, 87)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(add)
                                    .addComponent(edits)
                                    .addComponent(deletes))))
                        .addGap(0, 13, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(215, 215, 215)
                        .addComponent(jLabel7)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(quyen)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(25, 25, 25)
                        .addComponent(jLabel7))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(82, 82, 82)
                        .addComponent(quyen)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 43, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel1)
                            .addComponent(machucvus, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(19, 19, 19)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel2)
                            .addComponent(tenchucvus, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel3)
                            .addComponent(ngaytaos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel4)
                            .addComponent(maluongs, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(khenthuongs, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(10, 10, 10)
                        .addComponent(add)
                        .addGap(46, 46, 46)
                        .addComponent(edits)
                        .addGap(45, 45, 45)
                        .addComponent(deletes)))
                .addGap(59, 59, 59)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(timkiems, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(45, 45, 45)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 229, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(32, 32, 32))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void editsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_editsActionPerformed
        // TODO add your handling code here:
        addActionPerformed(evt);
    }//GEN-LAST:event_editsActionPerformed

    private void deletesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_deletesActionPerformed
        // TODO add your handling code here:

        if(MessageDialog.showConfirmDialog(mains, "Bạn chắc chắn muốn xóa bản ghi này không", "Thông báo") == JOptionPane.NO_OPTION){
            return;
        }
        try{
//            chucvuDao dao = new chucvuDao();
            String id = String.valueOf(ids);
            if(dao.delete(id)){
                MessageDialog.showMessageDialog(mains, "Xóa bản ghi thành công", "Thông báo");
                loadDataTable();
            }else{
                MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "Lỗi");
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "lỗi");
        }
    }//GEN-LAST:event_deletesActionPerformed

    private void tbltableMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tbltableMouseClicked
        // TODO add your handling code here:
        int row = tbltable.getSelectedRow();
        try{
            if(row >= 0){
                ids = (int) tbltable.getValueAt(row, 0);
//                chucvuDao dao = new chucvuDao();
                chucvu cv = dao.findAllid(ids);
                String machucvu = String.valueOf(cv.getMachucvu());
                String maluong = String.valueOf(cv.getTienluong_id());
                String khenthuong = String.valueOf(cv.getKhenthuong());
                if(cv != null){
                    machucvus.setText(machucvu);
                    tenchucvus.setText(cv.getTenchucvu());
                    ngaytaos.setText(cv.getNgaytao());
                    maluongs.setText(maluong);
                    khenthuongs.setText(khenthuong);
                }
            }
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_tbltableMouseClicked

    private void timkiem(){
        try{
//            chucvuDao dao = new chucvuDao();
            List<chucvu> list = dao.timkiem(timkiems.getText());
            model.setRowCount(0);
            for(chucvu cv : list){
                model.addRow(new Object[] {
                    cv.getId(), cv.getMachucvu(), cv.getTenchucvu(), cv.getNgaytao(), cv.getTienluong_id(), cv.getKhenthuong()
                });
            }
            
            model.fireTableDataChanged();
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
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

        StringBuilder sb = new StringBuilder();

        DataValidor.kiemtra(machucvus, sb, "Mã chức vụ không được để trống");
        DataValidor.kiemtra(tenchucvus, sb, "Tên chức vụ không được để trống");
        DataValidor.kiemtra(ngaytaos, sb, "Ngày tạo không được để trống");
        DataValidor.kiemtra(maluongs, sb, "Mã lương không được để trống");
        DataValidor.kiemtra(khenthuongs, sb, "Khen thưởng không được để trống");

        if(sb.length() > 0){
            MessageDialog.showMessageError(mains, sb.toString(), "Lỗi");
            return;
        }

        int machucvu = Integer.parseInt(machucvus.getText());
        int maluong = Integer.parseInt(maluongs.getText());
        int khenthuong = Integer.parseInt(khenthuongs.getText());

        try{
            chucvu cv = new chucvu();
            cv.setMachucvu(machucvu);
            cv.setTenchucvu(tenchucvus.getText());
            cv.setNgaytao(ngaytaos.getText());
            cv.setTienluong_id(maluong);
            cv.setKhenthuong(khenthuong);
//            chucvuDao dao = new chucvuDao();
            if(dao.findAllids(machucvu) != null){
                if(MessageDialog.showConfirmDialog(mains, "Bạn muốn cập nhật không", "Thông báo") == JOptionPane.NO_OPTION){
                    return;
                }

                chucvu cvs = new chucvu();
                cvs.setId(ids);
                cvs.setMachucvu(machucvu);
                cvs.setTenchucvu(tenchucvus.getText());
                cvs.setNgaytao(ngaytaos.getText());
                cvs.setTienluong_id(maluong);
                cvs.setKhenthuong(khenthuong);
                if(dao.update(cvs)){
                    MessageDialog.showMessageDialog(mains, "Update thành công", "Thông báo");
                    loadDataTable();
                }else{
                    MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "Lỗi");
                }
            }else{
                if(dao.insert(cv)){
                    MessageDialog.showMessageDialog(mains, "Thêm dữ liệu thành công", "Thông báo");
                    loadDataTable();
                }else{
                    MessageDialog.showMessageError(mains, "Đã có lỗi xảy ra", "lỗi");
                }
            }

        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }//GEN-LAST:event_addActionPerformed

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
    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        // TODO add your handling code here:
        initTable();
        
        loadDataTable();
        
        phanquyen();
        checkLogin();
    }//GEN-LAST:event_formWindowOpened

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
            java.util.logging.Logger.getLogger(chucvuss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(chucvuss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(chucvuss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(chucvuss.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                chucvuss dialog = new chucvuss(new javax.swing.JFrame(), true);
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
    private javax.swing.JButton deletes;
    private javax.swing.JButton edits;
    private javax.swing.Box.Filler filler1;
    private javax.swing.Box.Filler filler2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField khenthuongs;
    private javax.swing.JTextField machucvus;
    private javax.swing.JTextField maluongs;
    private javax.swing.JTextField ngaytaos;
    private javax.swing.JButton quyen;
    private javax.swing.JTable tbltable;
    private javax.swing.JTextField tenchucvus;
    private javax.swing.JTextField timkiems;
    // End of variables declaration//GEN-END:variables
}
