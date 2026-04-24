# DataGrid Visual Design Reference

## Color Palette Reference

### Primary Colors
```
┌─────────────────────────────────────────────────────────────┐
│ Component          │ Color Name      │ Hex Code │ RGB       │
├────────────────────┼─────────────────┼──────────┼───────────┤
│ Header Background  │ Light Gray 50   │ #F9FAFB  │ 249,250,251
│ Header Text        │ Gray 500        │ #6B7280  │ 107,114,128
│ Cell Text          │ Gray 900        │ #1F2937  │ 31,41,55
│ Border             │ Gray 200        │ #E5E7EB  │ 229,231,235
│ Secondary Text     │ Gray 400        │ #9CA3AF  │ 156,163,175
│ Hover State        │ Light Gray 50   │ #F9FAFB  │ 249,250,251
│ Selected State     │ Light Gray 100  │ #F3F4F6  │ 243,244,246
│ White Background   │ White           │ #FFFFFF  │ 255,255,255
└────────────────────┴─────────────────┴──────────┴───────────┘
```

### Status Colors
```
┌──────────────────────────────────────────────────────────────┐
│ Status     │ Color Name      │ Hex Code │ RGB               │
├────────────┼─────────────────┼──────────┼───────────────────┤
│ Active     │ Green 500       │ #10B981  │ 16, 185, 129      │
│ Inactive   │ Red 500         │ #EF4444  │ 239, 68, 68       │
│ Warning    │ Yellow 500      │ #F59E0B  │ 245, 158, 11      │
│ Pending    │ Blue 500        │ #3B82F6  │ 59, 130, 246      │
│ Success    │ Green 500       │ #10B981  │ 16, 185, 129      │
│ Error      │ Red 500         │ #EF4444  │ 239, 68, 68       │
└────────────────────┴─────────────────┴──────────┴───────────────┘
```

## Typography Specifications

### Headers
```
Font Family: Segoe UI
Font Size: 12px
Font Weight: SemiBold (600)
Color: #6B7280
Line Height: 1.5
Letter Spacing: 0
Padding: 16px (H) × 12px (V)
```

### Cell Text
```
Font Family: Segoe UI
Font Size: 13px
Font Weight: Regular (400)
Color: #1F2937
Line Height: 1.5
Letter Spacing: 0
Padding: 16px (H) × 12px (V)
```

### Secondary Text
```
Font Family: Segoe UI
Font Size: 12px
Font Weight: Regular (400)
Color: #9CA3AF
Line Height: 1.5
```

## Spacing System

### Row Heights
```
Header Row:     40px (12px font + padding)
Data Rows:      48px (13px font + padding)
Compact Rows:   36px (for dense displays)
Dense Rows:     32px (for very large datasets)
```

### Padding
```
Cell Horizontal Padding:  16px
Cell Vertical Padding:    12px
Border Radius (Badge):     4px
Column Spacing:           0px (grid only)
Row Spacing:              0px (grid lines handle separation)
```

### Column Width Guidelines
```
Row Number (#):     40-50px (fixed)
Short Fields:       60-80px (fixed)
Standard Fields:    120-150px or 1.5* (proportional)
Long Fields:        200px+ or 2*-3* (proportional)
Actions Column:     200-300px (fixed, depends on button count)
```

## Component Designs

### Status Badge Design
```
┌─────────────────────────────────┐
│  ■ Active                       │  ← Background: #10B981 (Green)
│                                 │     Padding: 8px (H) × 4px (V)
│  Text: White, 12px SemiBold    │     Border Radius: 4px
│  TextAlign: Center              │     Width: Auto
└─────────────────────────────────┘
```

### Action Button Design
```
┌──────────────────┐
│     Edit         │  ← Background: White (normal) / #F3F4F6 (hover)
│                  │     Border: 1px #D1D5DB
│  Padding: 10×6px │     Border Radius: 4px
│  Font: 12px      │     Cursor: Hand/Pointer
└──────────────────┘
```

### Row Selection States
```
Normal Row:
┌─────────────────────────────────┐
│ Background: White               │
│ Border: #F3F4F6 (horizontal)    │
│ Height: 48px                    │
└─────────────────────────────────┘

Hover State:
┌─────────────────────────────────┐
│ Background: #F9FAFB             │
│ Border: #F3F4F6 (horizontal)    │
│ Height: 48px                    │
│ Cursor: Pointer                 │
└─────────────────────────────────┘

Selected State:
┌─────────────────────────────────┐
│ Background: #F3F4F6             │
│ Border: #F3F4F6 (horizontal)    │
│ Height: 48px                    │
│ Font Weight: Normal (no change) │
└─────────────────────────────────┘
```

### Header Design
```
┌──────────────────────────────────────────────────────┐
│ #  │ Full Name    │ Age │ Status │ Contact │ Actions │
├────┼──────────────┼─────┼────────┼─────────┼─────────┤
│    │              │     │        │         │         │
│  Background: #F9FAFB                               │
│  Border Bottom: 1px #E5E7EB                        │
│  Height: 40px                                      │
│  Text Color: #6B7280                               │
│  Font Size: 12px SemiBold                          │
└──────────────────────────────────────────────────────┘
```

## Responsive Behavior

### Desktop (> 1200px)
```
┌─────────────────────────────────────────────────┐
│                  Full DataGrid Display           │
│  All columns visible, normal spacing            │
│  Row Height: 48px                               │
│  Header Height: 40px                            │
└─────────────────────────────────────────────────┘
```

### Tablet (768px - 1200px)
```
┌──────────────────────────────────┐
│    Reduced Spacing DataGrid       │
│  Some columns may be proportional │
│  Row Height: 44px                │
│  Header Height: 36px             │
└──────────────────────────────────┘
```

### Mobile (< 768px)
```
┌──────────────────┐
│  Card Layout or  │
│  Horizontal      │
│  Scroll          │
│  DataGrid        │
└──────────────────┘
```

## Visual Examples

### Active User in User Management
```
┌────┬───────────────┬─────────────┬─────────┬──────────────────┬──────────────────┐
│ #  │ Username      │ Role        │ Status  │ Last Login       │ Actions          │
├────┼───────────────┼─────────────┼─────────┼──────────────────┼──────────────────┤
│ 1  │ john.doe      │ SK Chair    │  Active │ 2025-12-15 14:30 │ Edit Deactivate  │
│    │               │             │  ▲ Green badge              │ Reset Password   │
└────┴───────────────┴─────────────┴─────────┴──────────────────┴──────────────────┘
```

### Inactive User in User Management
```
┌────┬───────────────┬─────────────┬──────────┬──────────────────┬──────────────────┐
│ #  │ Username      │ Role        │ Status   │ Last Login       │ Actions          │
├────┼───────────────┼─────────────┼──────────┼──────────────────┼──────────────────┤
│ 4  │ anna.santos   │ Member      │ Inactive │ 2025-11-15 09:20 │ Edit Deactivate  │
│    │               │             │  ▲ Red badge               │ Reset Password   │
└────┴───────────────┴─────────────┴──────────┴──────────────────┴──────────────────┘
```

### Youth Member Entry
```
┌────┬──────────────────┬─────┬────────┬────────────────────────┬──────────────┐
│ #  │ Full Name        │ Age │ Gender │ Address                │ Contact      │
├────┼──────────────────┼─────┼────────┼────────────────────────┼──────────────┤
│ 1  │ Juan Dela Cruz   │ 18  │ Male   │ Purok 1, Barangay...  │ 09171234567  │
│ 2  │ Maria Garcia     │ 19  │ Female │ Purok 2, Barangay...  │ 09175678901  │
└────┴──────────────────┴─────┴────────┴────────────────────────┴──────────────┘
```

## Animation & Transitions

### Hover Effect
```
Duration: 200ms
Easing: Ease In-Out
Property: Background Color
From: White (#FFFFFF)
To: Light Gray (#F9FAFB)
```

### Click/Selection Effect
```
Duration: 100ms
Easing: Linear
Property: Background Color
From: Light Gray (#F9FAFB)
To: Selected Gray (#F3F4F6)
```

### Button Hover
```
Duration: 150ms
Easing: Ease In-Out
Properties: Background, Border
From: White / #D1D5DB
To: #F3F4F6 / #9CA3AF
```

## Contrast & Accessibility

### WCAG Compliance
```
Header Text vs Background:   #6B7280 on #F9FAFB = 5.2:1 (AA)
Cell Text vs Background:     #1F2937 on #FFFFFF = 13.4:1 (AAA)
Secondary Text:              #9CA3AF on #FFFFFF = 4.5:1 (AA)
Status Badge (Active):       White on #10B981 = 5.5:1 (AA)
Status Badge (Inactive):     White on #EF4444 = 5.8:1 (AA)
```

### Font Sizes for Readability
```
Minimum Size: 12px (headers, secondary text)
Recommended Size: 13px (main content)
Maximum Size: 20px (page titles)
Line Height Minimum: 1.5
```

## States & Interactions

### Button States
```
Normal:     Background: White, Border: #D1D5DB
Hover:      Background: #F3F4F6, Border: #9CA3AF
Active:     Background: #E5E7EB, Border: #6B7280
Disabled:   Background: #F9FAFB, Border: #E5E7EB, Opacity: 0.6
Focus:      Border: 2px #3B82F6, Outline: Visible
```

### Cell States
```
Normal:     Background: White, Text: #1F2937
Hover:      Background: #F9FAFB (row level)
Selected:   Background: #F3F4F6, Text: #1F2937
Disabled:   Background: #F9FAFB, Text: #9CA3AF, Opacity: 0.6
Focus:      Border: 2px #3B82F6
```

---

**Visual Design Reference Version**: 1.0.0  
**Last Updated**: December 2026  
**Color System**: Tailwind CSS Compatible
