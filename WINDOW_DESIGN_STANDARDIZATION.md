# SK System Window Design Standardization

## Overview
All windows in the SK System application have been standardized to use the same design as ChairpersonDashboard with:
- **Blue active tab highlighting** (#A4BEF1)
- **Dark blue role badge** (#002B6F)
- **Consistent header format** showing "Lastname, Name" with role below

## Changes Made

### 1. New File: WindowTemplateStyles.xaml
Created a centralized resource dictionary containing shared styles for:
- Navigation items
- Topbar styling
- Role badge styling
- Main title and subtitle styles
- User info text styles

### 2. Updated Windows

#### ChairpersonUserManagement.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge from gray (#374151) to dark blue (#FF002B6F)
- Changed active tab highlight from gray (#E5E7EB) to light blue (#FFA4BEF1)
- Header already had "Lastname, Name" format

#### YouthManagement.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge to dark blue (#FF002B6F)
- Changed active tab (Youth Management) to light blue (#FFA4BEF1)
- Simplified topbar to show "Lastname, Name" with role below

#### EventManagement.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge to dark blue (#FF002B6F)
- Changed active tab (Events) to light blue (#FFA4BEF1)
- Simplified topbar to show "Lastname, Name" with role below

#### Attendance.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge to dark blue (#FF002B6F)
- Changed active tab (Attendance) to light blue (#FFA4BEF1)
- Simplified topbar to show "Lastname, Name" with role below

#### Reports.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge to dark blue (#FF002B6F)
- Changed active tab (Reports) to light blue (#FFA4BEF1)
- Simplified topbar to show "Lastname, Name" with role below

#### AuditTrail.xaml
✅ **Changes:**
- Added WindowTemplateStyles.xaml reference
- Changed role badge to dark blue (#FF002B6F)
- Changed active tab (Audit Trail) to light blue (#FFA4BEF1)
- Simplified topbar to show "Lastname, Name" with role below

## Design Details

### Color Palette
| Element | Color | Hex Code |
|---------|-------|----------|
| Active Tab Background | Light Blue | #FFA4BEF1 |
| Role Badge Background | Dark Blue | #FF002B6F |
| Sidebar Background | Light Gray | #F3F4F6 |
| Primary Text | Dark Gray | #1F2937 |
| Secondary Text | Medium Gray | #9CA3AF |

### Topbar Format
All windows now display user information in the format:
```
Lastname, Name
SK Chairperson
```
Followed by a logout button.

### Sidebar Navigation
- Active tab has light blue background (#FFA4BEF1) with left blue border
- Inactive tabs have transparent background
- Role badge displays dark blue background (#FF002B6F)

## Files Modified
- ChairpersonUserManagement.xaml
- YouthManagement.xaml
- EventManagement.xaml
- Attendance.xaml
- Reports.xaml
- AuditTrail.xaml

## Files Created
- WindowTemplateStyles.xaml

## Build Status
✅ **Successful** - All changes compile without errors

## Next Steps
1. Test navigation between windows
2. Verify colors match design specifications across all screens
3. Consider implementing theme switching if needed in the future
4. Update any remaining windows (MainWindow, etc.) to match this standard

---

**Completed**: December 2026
**Version**: 1.0.0
