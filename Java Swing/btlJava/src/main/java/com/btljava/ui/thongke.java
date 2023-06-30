/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.ui;

import com.btljava.dao.impl.hoadonDao;
import com.btljava.dao.impl.khoDao;
import com.btljava.helper.MessageDialog;
import com.btljava.model.hoadon;
import com.btljava.model.kho;
import java.util.List;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author ASUS
 */
public class thongke extends javax.swing.JPanel {
    private DefaultTableModel model;
    private fromMain mains;
    /**
     * Creates new form thongke
     */
    public thongke() {
        initComponents();
        inittable();
        
        loadDataTable();
        
        daban();
        
        tonkho();
        initTable();
        loadDataTables();
    }
    
    private void inittable(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Mã bệnh nhân", "Ngày ra", "Phương pháp điều trị", "Miêu tả", "Mã thuốc", "Số lượng", "Tổng tiền thuốc", "Tổng tiền", "Ngày tạo"
        });
        
        tblTable.setModel(model);
    }
    
    private void loadDataTable(){
        try{
            hoadonDao dao = new hoadonDao();
            List<hoadon> list = dao.sapxxep();
            model.setRowCount(0);
            for(hoadon hd : list){
                model.addRow(new Object[] {
                    hd.getId(), hd.getMabenhnhan(), hd.getNgayra(), hd.getPhuongphapdieutri(), 
                    hd.getMieuta(), hd.getThuoc_id(), hd.getSoluong(), hd.getTongtienthuoc(), hd.getTongtien(), hd.getNgaytao()
                });
            }
            model.fireTableDataChanged();
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void daban(){
        try{
            int sum = 0;
            int tongtien = 0;
            hoadonDao dao = new hoadonDao();
            List<hoadon> list = dao.findAll();
            for(hoadon hd : list){
                hd.getId();
                hd.getMabenhnhan();
                hd.getNgayra();
                hd.getPhuongphapdieutri();
                hd.getMieuta(); 
                hd.getThuoc_id(); 
                hd.getSoluong(); 
                hd.getTongtienthuoc();
                hd.getTongtien();
                hd.getNgaytao();
                tongtien = hd.getTongtien();
                sum = sum + tongtien;
            }
            
            
//            for(int i = 1; i <= list.size(); i++){
//                sum = sum + tongtien;
//            }
            
            String tong = String.valueOf(sum);
            doanhthu.setText(tong + " Đồng");
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void tonkho(){
        try{
            int tongban = 0;
            int sum = 0;
            int tonkho = 0;
            int soluong = 0;
            khoDao dao = new khoDao();
            List<kho> list = dao.findAll();
            
            
                for(kho kh : list){
                    kh.getId();
                    kh.getSanpham_id();
                    kh.getSoluong();
                    kh.getSoluongnhap();
                    kh.getDaban();
                    //kh.getTonkho();
                    kh.getNgaytao();


                    tonkho = kh.getTonkho();
                    sum = sum + tonkho;
                    soluong = kh.getDaban();
                    tongban = tongban + soluong;
                }
                
            
            
//            for(int i = 1; i <= list.size(); i++){
//                    sum = sum + tonkho;
//                    //tongban = tongban + soluong;
//            }
            
            
            
            String tong = String.valueOf(sum);
            String tongdaban = String.valueOf(tongban);
            tonkhos.setText(tong + " Sản phẩm");
            tongmuahang.setText(tongdaban + " Sản phẩm");
        }catch(Exception e){
            e.printStackTrace();
            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
        }
    }
    
    private void initTable(){
        model = new DefaultTableModel();
        model.setColumnIdentifiers(new String[] {
            "ID", "Mã sản phẩm", "Số lượng", "Số lượng nhập", "Đã bán", "Tồn kho", "Ngày tạo"
        });
        
        tblTable.setModel(model);
    }
    
    private void loadDataTables(){
        try{
            khoDao dao = new khoDao();
            List<kho> list = dao.findAll();
            model.setRowCount(0);
            for(kho kh : list){
                model.addRow(new Object[] {
                    kh.getId(), kh.getSanpham_id(), kh.getSoluong(), kh.getSoluongnhap(), kh.getDaban(), kh.getTonkho(), kh.getNgaytao()
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

        jLabel1 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblTable = new javax.swing.JTable();
        tongmuahang = new javax.swing.JLabel();
        doanhthu = new javax.swing.JLabel();
        tonkhos = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblTable1 = new javax.swing.JTable();

        jLabel1.setText("Tổng số lượng bán trong tháng");

        jLabel3.setText("Doanh thu trong tháng");

        jLabel4.setText("Số lượng tồn kho");

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
        jScrollPane1.setViewportView(tblTable);

        tongmuahang.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tongmuahang.setText("jLabel2");

        doanhthu.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        doanhthu.setText("jLabel2");

        tonkhos.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        tonkhos.setText("jLabel2");

        jButton1.setText("Làm mới");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        tblTable1.setModel(new javax.swing.table.DefaultTableModel(
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
        tblTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblTable1MouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblTable1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane1))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(58, 58, 58)
                                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 193, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(94, 94, 94)
                                .addComponent(tongmuahang, javax.swing.GroupLayout.PREFERRED_SIZE, 149, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(41, 41, 41)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 162, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(tonkhos, javax.swing.GroupLayout.PREFERRED_SIZE, 141, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(55, 55, 55)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 186, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 117, Short.MAX_VALUE)
                                .addComponent(jButton1))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(doanhthu, javax.swing.GroupLayout.PREFERRED_SIZE, 145, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(0, 0, Short.MAX_VALUE))))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane2)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(doanhthu)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(tongmuahang, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(tonkhos, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 280, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 68, Short.MAX_VALUE)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 302, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(30, 30, 30))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        loadDataTable();
        daban();
        tonkho();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void tblTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblTable1MouseClicked
        // TODO add your handling code here:

//        try{
//            int row = tblTable.getSelectedRow();
//            if(row >= 0){
//                ids = (int) tblTable.getValueAt(row, 0);
//                khoDao dao = new khoDao();
//                kho list = dao.findAllid(ids);
//                String sanphamid = String.valueOf(list.getSanpham_id());
//                String soluong = String.valueOf(list.getSoluong());
//                String soluongnhap = String.valueOf(list.getSoluongnhap());
//                String daban = String .valueOf(list.getDaban());
//                String tonkho = String.valueOf(list.getTonkho());
//                if(list != null){
//                    masanphams.setText(sanphamid);
//                    soluongs.setText(soluong);
//                    soluongnhaps.setText(soluongnhap);
//                    dabans.setText(daban);
//                    tonkhos.setText(tonkho);
//                    ngaytaos.setText(list.getNgaytao());
//                }
//            }
//        }catch(Exception e){
//            e.printStackTrace();
//            MessageDialog.showMessageError(mains, e.getMessage(), "Lỗi");
//        }
    }//GEN-LAST:event_tblTable1MouseClicked


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel doanhthu;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable tblTable;
    private javax.swing.JTable tblTable1;
    private javax.swing.JLabel tongmuahang;
    private javax.swing.JLabel tonkhos;
    // End of variables declaration//GEN-END:variables
}
